using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Repository
{
    public class ReportsRepository : Conexao_Mysql, BaseRepo.IReportDal
    {












        public object HistoricoRetornoLigacoes(String dt_in, String dt_fim, String opera)
        {
            object j = null;
            
            try
            {
                AbrirConexao();


                String Str = " Select total_carteira,total_Contatos,total_Retorno ";
                Str += " FROM( ";
                // Captura todos os clientes com estatus ativo ou pendentes
                Str += " (Select Count(id_cliente) as total_carteira ";
                Str += " from( ";
                Str += " Select distinct id_cliente, ";
                Str += " (CASE WHEN  isnull(u.operador) THEN c.canal_venda ELSE u.operador END) as Carteira ";
                Str += " FROM lista_contato c ";
                Str += " Left Join tab_carteira_usuario u on(c.canal_venda = u.carteira) ";
                Str += " where Left(situacao, 1) in ('A', 'P') ";
                Str += " )t  ";
               
                if (opera != "Todos")
                {
                    Str += " WHERE Carteira='" + opera.Trim() + "'";
                }

                Str += " ) as a, ";
                // Captura todos os clientes contactados (Pode ter sido contactados mais de uma vez e contará como 1
                //  considera o periodo do contato e o usuario do operador no filtro
                // aqui o contato pode ter ocorrido dentro ou fora da carteira e independe do status do cliente 
                // exclui status inativos . aqueles que nao geram uma chamada
                Str += " (Select Count(id_cliente) as total_Contatos from ";
                Str += " (Select distinct c.id_cliente,";
                Str += "  h.operador as Carteira, ";
                Str += " h.Dt_Contato ";
                Str += " FROM lista_contato c inner join ";
                Str += " (Select id_contato, Dt_Contato, operador,`status` FROM tab_historico_contato ";
                Str += " WHERE Dt_Contato >= '" + dt_in + "'  and Dt_Contato<= '" + dt_fim + " 23:59:59') h ";

                Str += " on(c.id = h.id_contato) ";
                Str += " Inner join tab_status s on(h.status = s.id) ";
                Str += " where s.ativo=1 and s.habilitado=1 ";
                Str += "   group by c.id_cliente order by  id_cliente) t1 ";
              
                if (opera != "Todos")
                {
                    Str += " WHERE Carteira='" + opera.Trim() + "'";
                }

                Str += " ) as b, ";
                //considera todo contato feito que seja uma venda direta  , vebda por cotacao ou apenas cotacao feita
                Str += " (Select Count(id) as total_Retorno from ";
                Str += " (Select  h.id, ";
                Str += " h.operador as Carteira, ";
                Str += " h.Dt_Contato ";
                Str += " FROM lista_contato c inner join tab_historico_contato h on(c.id = h.id_contato) ";
                Str += " where h.status in (14, 17, 5) ";
                Str += " ) t2 ";
                Str += " WHERE Dt_Contato >= '" + dt_in + "'  and Dt_Contato<= '" + dt_fim + " 23:59:59'";
                if (opera != "Todos")
                {
                    Str += " AND Carteira='" + opera.Trim() + "'";
                }
                Str += " ) as r )";



                using (Cmd = new MySqlCommand(Str, Con))
                {
                    //    Cmd.Parameters.AddWithValue("@dtIni", dt_in);
                    //     Cmd.Parameters.AddWithValue("@dtFim", dt_fim);
                    Dr = Cmd.ExecuteReader();


                    if (Dr.Read())
                    {                     
                        var carteira = Convert.ToString(Dr["total_carteira"]);
                        var contatados = Convert.ToString(Dr["total_Contatos"]);
                        var retorno = Convert.ToString(Dr["total_Retorno"]);
                        j = new { Total_Carteira = carteira, Total_Contatados = contatados, Total_retorno = retorno };

                    }
                }
            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("Erro em HistoricoRetornoLigacoes repository: " + ex.Message.ToString(), MessageType.Error);
            }
            finally
            {
                FecharConexao();
            }
            return j;

        }

        public List<LigacaoMotivoDTO> HistoricoCotacaoVenda(String dt_in, String dt_fim, String opera, int st)
        {



            var lista = new List<LigacaoMotivoDTO>();


            try
            {
                AbrirConexao();

                String Str = "Select Sum(cotacoes) as tot_Cotacoes,sum(vendas) as tot_Vendas ";

                Str += " FROM( ";

                Str += " SELECT ";
                Str += " (Case ";
                Str += " When coalesce(a.`status`, 0) = 5 then 1 Else  0 End) as cotacoes,";
                Str += " (Case";
                Str += " When coalesce(a.`status`, 0) = 14 then 1 Else  0 End) as vendas";

                Str += " FROM tab_historico_contato a Left Join tab_status b on (a.`status`= b.id) ";
                Str += " WHERE Dt_Contato >= '" + dt_in + "'  and Dt_Contato<= '" + dt_fim + " 23:59:59' and b.habilitado=1 ";
                if (opera != "Todos")
                {
                    Str += " AND Operador='" + opera.Trim() + "'";
                }
                Str += ") t";






                using (Cmd = new MySqlCommand(Str, Con))
                {
                    //    Cmd.Parameters.AddWithValue("@dtIni", dt_in);
                    //     Cmd.Parameters.AddWithValue("@dtFim", dt_fim);
                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new LigacaoMotivoDTO();

                        item_lista.Ligacao = Convert.ToInt32(Dr["tot_Cotacoes"]);
                        item_lista.Motivo = Convert.ToInt32(Dr["tot_Vendas"]);


                        //Adiciona na lista
                        lista.Add(item_lista);
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em ListarStatusContatos repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }




            return lista;








        }


        public object HistoricoVendasTotais(String dt_in, String dt_fim, String opera)
        {
            object j = null;
            try
            {
                AbrirConexao();

                String Str = "Select  sum(VendasCotacao) as Total_vcotacao,sum(VendasDiretas) as Total_vdireta";
                Str += " FROM ( SELECT ";
                Str += " (CASE ";
                Str += " WHEN h.status= 14 THEN 1 ELSE 0 END) as VendasCotacao, ";
                Str += " (CASE ";
                Str += " WHEN h.status= 17 THEN 1 ELSE 0 END) as VendasDiretas ";
                Str += "   FROM lista_contato c inner join tab_historico_contato h on(c.id = h.id_contato) ";
                Str += " and Dt_Contato >= '" + dt_in + "'  and Dt_Contato<= '" + dt_fim + " 23:59:59'";
                if (opera != "Todos")
                {
                    Str += " AND h.Operador='" + opera.Trim() + "'";
                }
                Str += ") as t";






                using (Cmd = new MySqlCommand(Str, Con))
                {
                    //    Cmd.Parameters.AddWithValue("@dtIni", dt_in);
                    //     Cmd.Parameters.AddWithValue("@dtFim", dt_fim);
                    Dr = Cmd.ExecuteReader();


                    if (Dr.Read())
                    {
                      


                        var VendasCotacao = Convert.ToString(Dr["Total_vcotacao"]);
                        var VendasDiretas = Convert.ToString(Dr["Total_vdireta"]);

                        j = new { Total_Vendas_Cotacao = VendasCotacao, Total_Vendas_Direta = VendasDiretas };
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em HistoricoClientesVendas repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }




            return j;








        }


        public List<HistoricoContatoDTO> HistoricoContatos(String dt_in, String dt_fim, String opera)
        {



            var lista = new List<HistoricoContatoDTO>();


            try
            {
                AbrirConexao();

                String Str = "Select ";
                Str += " c.id_cliente,";
                Str += " c.cliente,";
                Str += " c.situacao,";
                Str += " c.canal_venda,";
                Str += " c.cep,";
                Str += " c.cnpj,";
                Str += " c.cidade,";
                Str += " c.uf ,";
                Str += " month(mes_maior_compra) as Mes,";
                Str += " c.valor_Maior_compra ,";
                Str += " c.dt_ult_compra,";
                Str += " h.historico,";
                Str += " s.descricao ,";
                Str += " h.dt_contato,";
                Str += " h.operador ";
                Str += "  FROM tab_Historico_contato h ";
                Str += " join tab_status s on(h.status= s.id) ";
                Str += " join lista_contato c on(h.id_contato= c.Id) ";

                Str += " WHERE Dt_Contato >= '" + dt_in + "'  and Dt_Contato<= '" + dt_fim + " 23:59:59' and s.habilitado=1 ";
                if (opera != "Todos")
                {
                    Str += " AND operador='" + opera.Trim() + "'";
                }
                Str += " group by c.id_cliente,c.nome_contato,c.situacao,c.cep,c.canal_venda,c.situacao,c.cnpj,c.cidade,c.uf ,";
                Str += " month(mes_maior_compra),c.valor_Maior_compra , c.dt_ult_compra,h.historico,s.descricao ,h.dt_contato,h.operador ";
                Str += " order by h.dt_contato ";






                using (Cmd = new MySqlCommand(Str, Con))
                {
                    //    Cmd.Parameters.AddWithValue("@dtIni", dt_in);
                    //     Cmd.Parameters.AddWithValue("@dtFim", dt_fim);
                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new HistoricoContatoDTO();

                        item_lista.Id_cliente = Convert.ToString(Dr["id_cliente"]);
                        item_lista.Cliente = Convert.ToString(Dr["cliente"]);
                        item_lista.Situacao = Convert.ToString(Dr["situacao"]);
                        item_lista.Canal_venda = Convert.ToString(Dr["canal_venda"]);
                        item_lista.Cep = Convert.ToString(Dr["cep"]);
                        item_lista.Cnpj = Convert.ToString(Dr["cnpj"]);
                        item_lista.Cidade = Convert.ToString(Dr["cidade"]);
                        item_lista.Estado = Convert.ToString(Dr["uf"]);

                        item_lista.Mes_maior_comp = (Dr["Mes"] == DBNull.Value ? 0 : Convert.ToInt32(Dr["Mes"]));
                        item_lista.Val_Maior_compra = (Dr["valor_Maior_compra"] == DBNull.Value ? "0" : Convert.ToString(Dr["valor_Maior_compra"]).Replace(".", ","));
                        item_lista.Dt_Ul_Compra = Convert.ToString(Dr["dt_ult_compra"]);
                        item_lista.Ocorrencia = Convert.ToString(Dr["historico"]);
                        item_lista.Acao_contato = Convert.ToString(Dr["descricao"]);
                        item_lista.Dt_contato = Convert.ToString(Dr["dt_contato"]);
                        item_lista.Operador = Convert.ToString(Dr["operador"]);









                        //Adiciona na lista
                        lista.Add(item_lista);
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em HistoricoContatos repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }




            return lista;








        }

        public object HistoricoVisaoGeral(String dt_in, String dt_fim, String opera)
        {
            object j = null;
            try
            {
                AbrirConexao();

                String Str = "Select Sum(cotacoes) as tot_Cotacoes,sum(vendas) as tot_Vendas,sum(outros) as tot_Outros ";
                Str += " FROM ";
                Str += " (SELECT ";
                Str += " (Case ";
                Str += "  When coalesce(a.`status`, 0) = 5 then 1 Else  0 End) as cotacoes, ";
                Str += "  (Case ";
                Str += " When coalesce(a.`status`, 0) in (14, 17) then 1 Else  0 End) as vendas, ";
                Str += " (Case ";
                Str += " When coalesce(a.`status`, 0) not in (14, 17, 5) and b.ativo = 1  then 1 Else  0 End) as outros ";
                Str += "  FROM tab_historico_contato a inner Join tab_status b on(a.`status`= b.id) ";

                Str += " WHERE a.Dt_Contato >= '" + dt_in + "'  and a.Dt_Contato<= '" + dt_fim + " 23:59:59' and b.habilitado=1 ";
                if (opera != "Todos")
                {
                    Str += " AND a.operador='" + opera.Trim() + "'";
                }
                Str += " )t ";

                using (Cmd = new MySqlCommand(Str, Con))
                {
                    //    Cmd.Parameters.AddWithValue("@dtIni", dt_in);
                    //     Cmd.Parameters.AddWithValue("@dtFim", dt_fim);
                    Dr = Cmd.ExecuteReader();


                    if (Dr.Read())
                    {

                        var Cotacoes = Convert.ToString(Dr["tot_Cotacoes"]);
                        var Vendas = Convert.ToString(Dr["tot_Vendas"]);
                        var Outros = Convert.ToString(Dr["tot_Outros"]);


                        //  j ="{\"Outros\":\""+ Outros+"\",\"Vendas\":\""+ Vendas+"\",\"Cotacoes\":\""+ Cotacoes+"\"}";

                        j = new { Tota_Outros = Outros, Total_Vendas = Vendas, Total_Contacao = Cotacoes };

                    }
                }
            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("Erro em HistoricoContatos repository: " + ex.Message.ToString(), MessageType.Error);
            }
            finally
            {
                FecharConexao();
            }
            return j;








        }
    }
}
