using MySql.Data.MySqlClient;
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
    public class ContatosRepository : Conexao_Mysql, BaseRepo.IcontatoDAL
    {


        public List<ContatosDTO> ListarContatos(String filtro)
        {
            var lista = new List<ContatosDTO>();


            try
            {
                AbrirConexao();


                String Str = "SELECT ";
                Str += "lista_contato.id,";
                Str += "canal_venda,";
                Str += "id_cliente,";
                Str += "cliente,";
                Str += "cidade,";
                Str += "cnpj,";
                Str += "dias_sem_compra,";
                Str += "situacao,";
                Str += "mes_maior_compra,";
                Str += "dt_ult_compra,";
                Str += "email, ";
                Str += "telefone,";
                Str += "status_Contato,";
                Str += "data_contato, ";
                Str += "data_agenda_contato,";
                Str += "endereco,";
                Str += "uf, ";
                Str += "cep,";
                Str += "bairro,";
                Str += "cod_municipio,";
                Str += "em_atendimento,";
                Str += "Entrega,";
                Str += "nome_contato,";
                Str += "coalesce(tab_status.descricao,'') as desc_st,";
                Str += "valor_Maior_compra ";
                Str += " FROM lista_contato ";
                Str += " LEFT JOIN tab_status ";
                Str += " ON lista_contato.status_Contato = tab_status.id ";
           
                if (!String.IsNullOrEmpty(filtro))
                {
                    Str += " " + filtro;
                }

                using (Cmd = new MySqlCommand(Str, Con))
                {


                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new ContatosDTO();

                        item_lista.Id = Convert.ToInt32(Dr["id"]);
                        item_lista.Canal_venda = Convert.ToString(Dr["canal_venda"]);
                        item_lista.Id_cliente = Convert.ToString(Dr["id_cliente"]);
                        item_lista.Cliente = Convert.ToString(Dr["cliente"]);
                        item_lista.Cidade = Convert.ToString(Dr["cidade"]);
                        item_lista.Cnpj = Convert.ToString(Dr["cnpj"]);

                        item_lista.Dias_sem_compra = Convert.ToInt32(Dr["dias_sem_compra"]);
                        item_lista.Situacao = Convert.ToString(Dr["situacao"]);
                        if (Dr["mes_maior_compra"] != DBNull.Value)
                            item_lista.Mes_Maior_compra = Convert.ToDateTime(Dr["mes_maior_compra"]);
                        if (Dr["dt_ult_compra"] != DBNull.Value)
                            item_lista.Dia_ult_compra = Convert.ToDateTime(Dr["dt_ult_compra"]);

                        item_lista.Email = Convert.ToString(Dr["email"]);
                        item_lista.Telefone = Convert.ToString(Dr["telefone"]);
                        if (Dr["status_Contato"] != DBNull.Value)
                            item_lista.Status_contato = Convert.ToInt32(Dr["status_Contato"]);
                        if (Dr["data_contato"] != DBNull.Value)
                            item_lista.Data_contato = Convert.ToDateTime(Dr["data_contato"]);
                        if (Dr["data_agenda_contato"] != DBNull.Value)
                            item_lista.Data_Agenda_contato = Convert.ToDateTime(Dr["data_agenda_contato"]);
                        item_lista.Endereco = Convert.ToString(Dr["endereco"]);
                        item_lista.EnderecoEntrega = Convert.ToString(Dr["Entrega"]);
                        item_lista.Estado = Convert.ToString(Dr["uf"]);
                        item_lista.Cep = Convert.ToString(Dr["cep"]);
                        item_lista.Bairro = Convert.ToString(Dr["bairro"]);
                        item_lista.Nome_contato = Convert.ToString(Dr["nome_contato"]);

                        if (Dr["cod_municipio"] != DBNull.Value)
                        {
                            item_lista.Cod_municipio = Convert.ToInt32(Dr["cod_municipio"]);

                        }
                        item_lista.Em_atendimento = Convert.ToInt32(Dr["em_atendimento"]);
                        item_lista.Descricao_status= Convert.ToString(Dr["desc_st"]);
                        item_lista.valorMaiorCompra = Convert.ToDecimal(Dr["valor_Maior_compra"]);

                        //Adiciona na lista
                        lista.Add(item_lista);
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro ao Listar contatos repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }

            return lista;
        }

        public List<ContatosDTO> ListarEnvioCorreio()
        {
            var lista = new List<ContatosDTO>();


            try
            {
                AbrirConexao();


                String Str = "SELECT lista_contato.Id,lista_contato.cliente";
                Str += " FROM lista_contato join ";

                Str += " virtua_tlmk.tab_historico_contato ";

                Str += " on lista_contato.Id = tab_historico_contato.id_contato ";
                Str += " join tab_status on tab_historico_contato.`status` = tab_status.id ";
                Str += "  where tab_status.descricao like '%Envio de amostra%' and Date(lista_contato.data_agenda_contato) >= date(now()) ";
                Str += " group by lista_contato.Id,lista_contato.cliente ";

                Str += " order by lista_contato.cliente ";

             
                using (Cmd = new MySqlCommand(Str, Con))
                {


                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new ContatosDTO();

                        item_lista.Id = Convert.ToInt32(Dr["id"]);
                        item_lista.Cliente = Convert.ToString(Dr["cliente"]);


                        //Adiciona na lista
                        lista.Add(item_lista);
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro ao Listar contatos correio repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }

            return lista;
        }

        public List<StatusContatoDTO> ListarStatusContatos()
        {
            var lista = new List<StatusContatoDTO>();


            try
            {
                AbrirConexao();


                String Str = "SELECT ";
                Str += "id,";
                Str += "descricao,";
                Str += "ativo";

                Str += " FROM tab_status WHERE habilitado=1";


                using (Cmd = new MySqlCommand(Str, Con))
                {


                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new StatusContatoDTO();

                        item_lista.Id = Convert.ToInt32(Dr["id"]);
                        item_lista.Descricao = Convert.ToString(Dr["descricao"]);
                        item_lista.Ativo = Convert.ToInt32(Dr["ativo"]);



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

        public String InserirHistorico(HistoricoDTO item)
        {
            String retorno = "OK";
            try
            {
                AbrirConexao();

                String Sql = "INSERT INTO tab_historico_contato  ";
                Sql += " (`id`,";
                Sql += " `historico`,";
                Sql += " `data_hora_retorno`,";
                Sql += " `status`,";
                Sql += " `dt_contato`,";
                Sql += " `operador`,";
                Sql += " `id_contato`)";
                Sql += " VALUES ";
                Sql += " (@vId,";
                Sql += " @historico,";
                Sql += " @data_hora_retorno,";
                Sql += " @status,";
                Sql += " @dt_contato,";
                Sql += " @operador,";
                Sql += " @id_contato)";


                using (Cmd = new MySqlCommand(Sql, Con))
                {
                    Cmd.CommandText = Sql;
                    Cmd.Parameters.AddWithValue("@vId", item.Id);
                    Cmd.Parameters.AddWithValue("@historico", item.Historico_Desc);
                    Cmd.Parameters.AddWithValue("@data_hora_retorno", item.Dt_retorno);

                    Cmd.Parameters.AddWithValue("@status", item.Status_contato);
                    Cmd.Parameters.AddWithValue("@dt_contato", item.Dt_contato);
                    Cmd.Parameters.AddWithValue("@operador", item.Operador);
                    Cmd.Parameters.AddWithValue("@id_contato", item.Id_contato);


                    Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                retorno = "Erro";
                LogEvento.EscreverEvento("Erro InserirHistorico repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }


            return retorno;
        }

        public List<HistoricoDTO> ListarHistoricoContato(Int32? id)
        {
            var lista = new List<HistoricoDTO>();


            try
            {
                AbrirConexao();


                String Str = " SELECT ";
                Str += " tab_historico_contato.id,";
                Str += " tab_historico_contato.historico,";
                Str += " tab_historico_contato.data_hora_retorno,";
                Str += " tab_status.descricao as st,";
                Str += " tab_historico_contato.dt_contato , ";
                Str += " tab_historico_contato.operador ,";
                Str += " tab_historico_contato.id_contato ";

                Str += " FROM tab_historico_contato";
                Str += " join tab_status on tab_historico_contato.status = tab_status.id WHERE tab_status.habilitado=1 ";
                if (id != null)
                {

              
                Str += " AND  tab_historico_contato.id_contato = @id";
                }

                using (Cmd = new MySqlCommand(Str, Con))
                {
                    Cmd.Parameters.AddWithValue("@id", id);

                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new HistoricoDTO();

                        item_lista.Id = Convert.ToString(Dr["id"]);
                        item_lista.Desc_status = Convert.ToString(Dr["st"]);
                        item_lista.Dt_contato = Convert.ToDateTime(Dr["dt_contato"]);
                        item_lista.Dt_retorno = Convert.ToDateTime(Dr["data_hora_retorno"]);
                        item_lista.Historico_Desc = Convert.ToString(Dr["historico"]);
                        item_lista.Id_contato = Convert.ToInt32(Dr["id_contato"]);
                        item_lista.Operador = Convert.ToString(Dr["operador"]);


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

        public List<HistoricoDTO> HistoricoAgrupado(String dt_in, String dt_fim, String opera)
        {

         

            var lista = new List<HistoricoDTO>();


            try
            {
                AbrirConexao();


                String Str = " SELECT Operador, Dt_Contato, descricao,ativo, nr_contatos FROM";
                Str += "( SELECT Operador,";
                Str += " DATE_FORMAT(dt_contato, '%Y-%m-%d') as Dt_Contato,";
                Str += "  tab_status.descricao,ativo, ";
                Str += " Count(tab_historico_contato.id) as nr_contatos";
                Str += "  FROM tab_historico_contato inner Join tab_status on tab_historico_contato.status = tab_status.Id and tab_status.habilitado=1 ";
                Str += "  Group by Operador,DATE_FORMAT(dt_contato, '%Y-%m-%d'), tab_status.descricao,tab_status.ativo) tabAgrupada ";
                Str += " WHERE Dt_Contato >= '"+ dt_in + "'  and Dt_Contato<= '" + dt_fim + "'  ";
                if (opera != "Todos")
                {
                    Str += " AND Operador='" + opera.Trim() + "'";
                }

                using (Cmd = new MySqlCommand(Str, Con))
                {
                //    Cmd.Parameters.AddWithValue("@dtIni", dt_in);
              //     Cmd.Parameters.AddWithValue("@dtFim", dt_fim);
                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new HistoricoDTO();

                        item_lista.ativo = Convert.ToInt32(Dr["ativo"]);
                        item_lista.Desc_status = Convert.ToString(Dr["descricao"]);
                        item_lista.Dt_contato = Convert.ToDateTime(Dr["Dt_Contato"]);
                        item_lista.Nr_contatos = Convert.ToInt32(Dr["nr_contatos"]);
                        item_lista.Operador = Convert.ToString(Dr["operador"]);


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

        public String AtualizarContato(ContatosDTO item)
        {
            String retorno = "OK";
            try
            {
                AbrirConexao();

                String Str = "UPDATE  lista_contato SET ";

                Str += " canal_venda=@canal_venda,";

                Str += " cliente=@cliente,";
                Str += " cidade=@cidade,";
                Str += " cnpj=@cnpj,";

                Str += " situacao=@situacao,";
                Str += " entrega=@entrega,";
                Str += " email=@email, ";
                Str += " telefone=@telefone,";
                Str += " status_Contato=@status_Contato,";
                Str += " data_contato=@data_contato, ";
                Str += " data_agenda_contato=@data_agenda_contato,";
                if (item.Cod_municipio != null)
                {
                    Str += " cod_municipio=@cod_Municipio,";
                }
                Str += " endereco=@endereco,";
                Str += " bairro=@bairro,";
                Str += " uf=@uf, ";
                Str += " cep=@cep,";
                Str += " nome_contato=@nome_contato";
                Str += " WHERE id=@vId";


                using (Cmd = new MySqlCommand(Str, Con))
                {
                    Cmd.CommandText = Str;
                    Cmd.Parameters.AddWithValue("@vId", item.Id);
                    Cmd.Parameters.AddWithValue("@canal_venda", item.Canal_venda);
                    Cmd.Parameters.AddWithValue("@cliente", item.Cliente);
                    Cmd.Parameters.AddWithValue("@situacao", item.Situacao);
                    Cmd.Parameters.AddWithValue("@email", item.Email);
                    Cmd.Parameters.AddWithValue("@telefone", item.Telefone);
                    Cmd.Parameters.AddWithValue("@status_Contato", item.Status_contato);
                    Cmd.Parameters.AddWithValue("@cidade", item.Cidade);
                    Cmd.Parameters.AddWithValue("@cnpj", item.Cnpj);
                    Cmd.Parameters.AddWithValue("@data_contato", item.Data_contato);
                    Cmd.Parameters.AddWithValue("@data_agenda_contato", item.Data_Agenda_contato);
                    if (item.Cod_municipio != null)
                    {
                        Cmd.Parameters.AddWithValue("@cod_Municipio", item.Cod_municipio);
                    }
                    Cmd.Parameters.AddWithValue("@nome_contato", item.Nome_contato);
                    Cmd.Parameters.AddWithValue("@endereco", item.Endereco);
                    Cmd.Parameters.AddWithValue("@entrega", item.EnderecoEntrega);
                    Cmd.Parameters.AddWithValue("@uf", item.Estado);
                    Cmd.Parameters.AddWithValue("@cep", item.Cep);
                    Cmd.Parameters.AddWithValue("@bairro", item.Bairro);

                    Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                retorno = "Erro";
                LogEvento.EscreverEvento("Erro AtualizarContato repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }


            return retorno;

        }

        public String AtualizarDadoFAturamento(ContatosDTO item)
        {
            String retorno = "OK";
            try
            {
                AbrirConexao();

                String Str = "UPDATE  lista_contato SET ";

                Str += " mes_maior_compra=@mes_maior_compra,";

                Str += " dias_sem_compra=@dias_sem_compra,";
                Str += " dt_ult_compra=@dt_ult_compra,";
                Str += " valor_Maior_compra=@valor_Maior_compra ";


                Str += " WHERE id_cliente=@vId";


                using (Cmd = new MySqlCommand(Str, Con))
                {
                    Cmd.CommandText = Str;
                    Cmd.Parameters.AddWithValue("@vId", item.Id_cliente);
                    Cmd.Parameters.AddWithValue("@mes_maior_compra", item.Mes_Maior_compra);

                    Cmd.Parameters.AddWithValue("@dias_sem_compra", item.Dias_sem_compra);
                    Cmd.Parameters.AddWithValue("@dt_ult_compra", item.Dia_ult_compra);
                    Cmd.Parameters.AddWithValue("@valor_Maior_compra", item.valorMaiorCompra);

                    Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                retorno = "Erro";
                LogEvento.EscreverEvento("Erro Atualizar  AtualizarDadoFAturamento repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }


            return retorno;

        }

        public String InserirContatosBulk(List<ContatosDTO> lista)
        {

            String resp = "OK";


            try
            {
                AbrirConexao();


                String str = "INSERT INTO lista_contato ";
                str += "(";
                str += "canal_venda,";
                str += "id_cliente,";
                str += "cliente,";
                str += "cidade,";
                str += "cnpj,";
                str += "dias_sem_compra,";
                str += "situacao,";
                str += "mes_maior_compra,";
                str += "dt_ult_compra,";
                str += "email, ";
                str += "telefone,";
                str += "data_agenda_contato,";
                str += "endereco,";
                str += "uf, ";
                str += "cep,";
                str += "bairro,";
                str += "valor_Maior_compra,";

                str += "cod_municipio)";
                str += " VALUES ";

                using (Cmd = new MySqlCommand(str, Con))
                {
                    var cont = 0;

                    foreach (var iteml in lista)
                    {
                        //if (iteml.Id_cliente == "036476008000176")
                        //{
                        //    var t = "OK";
                        //}
                        //          Cmd.Parameters.AddWithValue("@data_leitura" + cont, iteml.Data_leitura);
                        Cmd.Parameters.AddWithValue("@canal_venda" + cont, iteml.Canal_venda);
                        Cmd.Parameters.AddWithValue("@id_cliente" + cont, iteml.Id_cliente);
                        Cmd.Parameters.AddWithValue("@cliente" + cont, iteml.Cliente);

                        Cmd.Parameters.AddWithValue("@cidade" + cont, iteml.Cidade);
                        Cmd.Parameters.AddWithValue("@cnpj" + cont, iteml.Cnpj);


                        Cmd.Parameters.AddWithValue("@situacao" + cont, iteml.Situacao);

                        Cmd.Parameters.AddWithValue("@mes_maior_compra" + cont, iteml.Mes_Maior_compra);

                        Cmd.Parameters.AddWithValue("@dias_sem_compra" + cont, iteml.Dias_sem_compra);
                        Cmd.Parameters.AddWithValue("@dt_ult_compra" + cont, iteml.Dia_ult_compra);
                        Cmd.Parameters.AddWithValue("@valor_Maior_compra" + cont, iteml.valorMaiorCompra);

                        Cmd.Parameters.AddWithValue("@email" + cont, iteml.Email);
                        Cmd.Parameters.AddWithValue("@telefone" + cont, iteml.Telefone);
                        Cmd.Parameters.AddWithValue("@endereco" + cont, iteml.Endereco);

                        Cmd.Parameters.AddWithValue("@uf" + cont, iteml.Estado);

                        var cep = (iteml.Cep + new string('0', 8)).Substring(0, 8);
                        Cmd.Parameters.AddWithValue("@cep" + cont, cep);



                        Cmd.Parameters.AddWithValue("@bairro" + cont, iteml.Bairro);

                        if (iteml.Data_Agenda_contato == null)
                        {
                            iteml.Data_Agenda_contato = DateTime.Now.Date;
                        }
                        Cmd.Parameters.AddWithValue("@data_agenda_contato" + cont, iteml.Data_Agenda_contato);


                        if (iteml.Cod_municipio == null)
                        {
                            iteml.Cod_municipio = 0;
                        }
                        Cmd.Parameters.AddWithValue("@cod_municipio" + cont, iteml.Cod_municipio);




                        if (cont > 0)
                        {
                            str += ",";
                        }

                        str += "(@canal_venda" + cont + ",";
                        str += "@id_cliente" + cont + ",";
                        str += "@cliente" + cont + ",";
                        str += "@cidade" + cont + ",";
                        str += "@cnpj" + cont + ",";
                        str += "@dias_sem_compra" + cont + ",";
                        str += "@situacao" + cont + ",";
                        str += "@mes_maior_compra" + cont + ",";
                        str += "@dt_ult_compra" + cont + ",";
                        str += "@email" + cont + ",";
                        str += "@telefone" + cont + ",";
                        str += "@data_agenda_contato" + cont + ",";
                        str += "@endereco" + cont + ",";
                        str += "@uf" + cont + ",";
                        str += "@cep" + cont + ",";
                        str += "@bairro" + cont + ",";
                        str += "@valor_Maior_compra" + cont + ",";
                        str += "@cod_municipio" + cont + ")";
                        cont++;
                    }
                    str += " ON DUPLICATE KEY UPDATE ";

                    str += "  mes_maior_compra = VALUES (mes_maior_compra),";
                    str += " valor_Maior_compra = VALUES(valor_Maior_compra),";
                    str += " dt_ult_compra = VALUES(dt_ult_compra),";
                    str += " situacao = VALUES(situacao),";
                    str += " dias_sem_compra = VALUES(dias_sem_compra)";

                    Cmd.CommandText = str;

                    Cmd.ExecuteNonQuery();




                }
            }
            catch (Exception ex)
            {
                resp = "ERRO";


                LogEvento.EscreverEvento("Erro InserirContatosBulk repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }

            return resp;
        }

        public String InserirContatosUnit(ContatosDTO item)
        {

            String resp = "OK";


            try
            {
                AbrirConexao();


                String str = "INSERT INTO lista_contato ";
                str += "(";
                str += "canal_venda,";
                str += "id_cliente,";
                str += "cliente,";
                str += "cidade,";
                str += "cnpj,";
                str += "dias_sem_compra,";
                str += "situacao,";
                str += "mes_maior_compra,";
                str += "dt_ult_compra,";
                str += "email, ";
                str += "telefone,";
                str += "data_agenda_contato,";
                str += "endereco,";
                str += "uf, ";
                str += "cep,";
                str += "bairro,";
                str += "valor_Maior_compra,";
                if (item.Data_contato != null)
                {
                    str += "data_contato,";
                }

                str += "cod_municipio,";
                str += "entrega,";
                str += "nome_contato)";
                str += " VALUES ";

                using (Cmd = new MySqlCommand(str, Con))
                {
                    var cont = 0;


                    //          Cmd.Parameters.AddWithValue("@data_leitura" + cont, iteml.Data_leitura);
                    Cmd.Parameters.AddWithValue("@canal_venda", item.Canal_venda);
                    Cmd.Parameters.AddWithValue("@id_cliente", item.Id_cliente);
                    Cmd.Parameters.AddWithValue("@cliente", item.Cliente);

                    Cmd.Parameters.AddWithValue("@cidade", item.Cidade);
                    Cmd.Parameters.AddWithValue("@cnpj", item.Cnpj);


                    Cmd.Parameters.AddWithValue("@situacao", item.Situacao);

                    Cmd.Parameters.AddWithValue("@mes_maior_compra", item.Mes_Maior_compra);

                    Cmd.Parameters.AddWithValue("@dias_sem_compra", item.Dias_sem_compra);
                    Cmd.Parameters.AddWithValue("@dt_ult_compra", item.Dia_ult_compra);
                    Cmd.Parameters.AddWithValue("@valor_Maior_compra", item.valorMaiorCompra);

                    Cmd.Parameters.AddWithValue("@email", item.Email);
                    Cmd.Parameters.AddWithValue("@telefone", item.Telefone);
                    Cmd.Parameters.AddWithValue("@endereco", item.Endereco);
                    Cmd.Parameters.AddWithValue("@entrega", item.EnderecoEntrega);
                    Cmd.Parameters.AddWithValue("@nome_contato", item.Nome_contato);

                    Cmd.Parameters.AddWithValue("@uf", item.Estado);

                    var cep = (item.Cep + new string('0', 8)).Substring(0, 8);
                    Cmd.Parameters.AddWithValue("@cep", cep);



                    Cmd.Parameters.AddWithValue("@bairro", item.Bairro);

                    if (item.Data_Agenda_contato == null)
                    {
                        item.Data_Agenda_contato = DateTime.Now.Date;
                    }
                    Cmd.Parameters.AddWithValue("@data_agenda_contato", item.Data_Agenda_contato);


                    if (item.Cod_municipio == null)
                    {
                        item.Cod_municipio = 0;
                    }
                    Cmd.Parameters.AddWithValue("@cod_municipio", item.Cod_municipio);
                    if (item.Data_contato != null)
                    {
                        Cmd.Parameters.AddWithValue("@data_contato", item.Data_contato);

                    }



                    str += "(@canal_venda,";
                    str += "@id_cliente,";
                    str += "@cliente,";
                    str += "@cidade,";
                    str += "@cnpj,";
                    str += "@dias_sem_compra,";
                    str += "@situacao,";
                    str += "@mes_maior_compra,";
                    str += "@dt_ult_compra,";
                    str += "@email,";
                    str += "@telefone,";
                    str += "@data_agenda_contato,";
                    str += "@endereco,";
                    str += "@uf,";
                    str += "@cep,";
                    str += "@bairro,";
                    str += "@valor_Maior_compra,";
                    if (item.Data_contato != null)
                    {
                        str += "@data_contato,";
                    }
                    str += "@cod_municipio,";
                    str += "@entrega,";
                    str += "@nome_contato)";

                    str += " ON DUPLICATE KEY UPDATE ";

                    str += "  mes_maior_compra = @mes_maior_compra,";
                    str += " valor_Maior_compra = @valor_Maior_compra,";
                    str += " dt_ult_compra = @dt_ult_compra,";
                    str += " situacao = @situacao,";
                    str += " dias_sem_compra = @dias_sem_compra";
                    str += " em_atendimento = 0";

                    Cmd.CommandText = str;

                    Cmd.ExecuteNonQuery();




                }
            }
            catch (Exception ex)
            {
                resp = "ERRO";


                LogEvento.EscreverEvento("Erro InserirContatosUnit repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }

            return resp;
        }

        public String BloqueiarContato(int Id, int st, String operador)
        {
            String retorno = "OK";
            try
            {
                AbrirConexao();

                String Str = "UPDATE  lista_contato SET ";

                Str += " em_atendimento =@vstat ";
            
                if (String.IsNullOrEmpty(operador))
                {
                    Str += " WHERE id=@vId";
                }
                else
                {
                    Str += " WHERE operador_ult_contato=@operador_ult_contato";
                }


                using (Cmd = new MySqlCommand(Str, Con))
                {
                    Cmd.CommandText = Str;
                    if (String.IsNullOrEmpty(operador))
                    {
                        Cmd.Parameters.AddWithValue("@vId", Id);
                    }
                    else
                    {
                        Cmd.Parameters.AddWithValue("@operador_ult_contato", operador);
                    }
                   

                    Cmd.Parameters.AddWithValue("@vstat", st);

                    Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                retorno = "Erro";
                LogEvento.EscreverEvento("Erro BloquearContato repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }


            return retorno;

        }

    }
}
