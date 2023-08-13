using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

using VirtuaConecta.Outbound.Utility;
using VirtuaConecta.Outbound.Parametros;
using System.Data.Odbc;
using Microsoft.VisualBasic;

namespace VirtuaConecta.Outbound.Repository
{
    public class ClienteInformixRepository : Conexao_informix, BaseRepo.IcontatoInformix
    {

        public List<ContatosDTO> ListarStatusContatos(String dias, String IdCliente)
        {
            var lista = new List<ContatosDTO>();


            try
            {
                AbrirConexao("dw");


                String Str = "SELECT ";
                Str += " cliente_canal_venda.descricao_canal_venda AS canal_venda,";
                Str += " cliente_canal_venda.cliente_fornecedor AS id_cliente,";
                Str += " TO_CHAR(fato_desempenho_cliente.quantidade_dias_sem_comprar) AS dias_sem_compra,";
                Str += " TO_CHAR(fato_desempenho_cliente.data_referencia_maior_compra, \" %Y -%m -%d %H:%M:%S.%F\") AS mes_maior_compra,";
                Str += " TO_CHAR(fato_desempenho_cliente.data_ultima_compra, \" %Y -%m -%d %H:%M:%S.%F\") AS dt_ult_compra,";
                Str += " TO_CHAR(fato_desempenho_cliente.valor_maior_compra) AS val_ult_compra,";
                Str += " c.nom_cliente AS razao,";
                Str += " c.end_cliente AS endereco,";
                Str += " c.den_bairro AS bairro,";
                Str += "  REPLACE(c.cod_cep, \"-\" ) AS cep,";
                Str += " (CASE WHEN upper(c.num_telefone)<> lower(c.num_telefone) THEN \"\" ";
                Str += " ELSE ";

                Str += "  REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(c.num_telefone, \"*\"), \"(\"), \")\"), \"-\"), \" \"), \".\"), \",\")  END) AS telefone,";

                Str += "    d.den_cidade AS cidade,";

                Str += " d.cod_uni_feder AS uf,";

                Str += " c.num_cgc_cpf AS cnpj,";

                Str += "  e.email, ";
                Str += "  c.ies_situacao AS situacao ";
                Str += " FROM cliente_canal_venda,";
                Str += " representante,";
                Str += " fato_desempenho_cliente,";
                Str += " logix:clientes c,";
                Str += " logix:cidades d,";
                Str += " (SELECT cliente_fornecedor,";
                Str += "   MAX(trim(coalesce(correio_eletronico, \"\"))) AS email ";

                Str += "  FROM logix: vdp_cli_fornec_cpl";
                Str += "   GROUP BY cliente_fornecedor) e ";
                Str += "  WHERE fato_desempenho_cliente.cliente_fornecedor = cliente_canal_venda.cliente_fornecedor ";
                Str += "  AND cliente_canal_venda.codigo_representante = representante.codigo_representante ";
                Str += "  AND c.cod_cliente = cliente_canal_venda.cliente_fornecedor ";
                Str += "  AND c.cod_cidade = d.cod_cidade ";
                Str += "  AND e.cliente_fornecedor = cliente_canal_venda.cliente_fornecedor ";
                if (!String.IsNullOrEmpty(dias))
                {
                    Str += "  AND fato_desempenho_cliente.quantidade_dias_sem_comprar >= " + dias;
                }
                if (!String.IsNullOrEmpty(IdCliente))
                {
                    Str += "  AND cliente_canal_venda.cliente_fornecedor= '" + IdCliente + "'";
                }

                Str += " ORDER BY cliente_canal_venda.cliente_fornecedor ";




                Cmd = new System.Data.Odbc.OdbcCommand(Str, Con);

                Cmd.CommandTimeout = 200;

                Dr = Cmd.ExecuteReader();


                while (Dr.Read())
                {
                    var item_lista = new ContatosDTO();

                    item_lista.Canal_venda = Convert.ToString(Dr["canal_venda"]).Trim();

                    item_lista.Id_cliente = Convert.ToString(Dr["id_cliente"]).Trim();

                    if (Dr["dias_sem_compra"] != DBNull.Value)
                        item_lista.Dias_sem_compra = Convert.ToInt32(Dr["dias_sem_compra"]);

                    if (Dr["mes_maior_compra"] != DBNull.Value)
                        item_lista.Mes_Maior_compra = Convert.ToDateTime(Dr["mes_maior_compra"]);

                    if (Dr["dt_ult_compra"] != DBNull.Value)
                        item_lista.Dia_ult_compra = Convert.ToDateTime(Dr["dt_ult_compra"]);

                    if (Dr["val_ult_compra"] != DBNull.Value)
                        item_lista.valorMaiorCompra = Convert.ToDecimal(Dr["val_ult_compra"]);

                    item_lista.Cliente = Convert.ToString(Dr["razao"]).Trim();
                    item_lista.Cnpj = Convert.ToString(Dr["cnpj"]).Trim();
                    item_lista.Endereco = Convert.ToString(Dr["endereco"]).Trim();
                    item_lista.Bairro = Convert.ToString(Dr["bairro"]).Trim();
                    item_lista.Cidade = Convert.ToString(Dr["cidade"]).Trim();
                    item_lista.Estado = Convert.ToString(Dr["uf"]).Trim();
                    item_lista.Email = Convert.ToString(Dr["email"]).Trim();
                    item_lista.Cep = Convert.ToString(Dr["cep"]).Trim();
                    item_lista.Situacao = Convert.ToString(Dr["situacao"]).Trim();
                    item_lista.Telefone = Convert.ToString(Dr["telefone"]).Trim();

                    try
                    {

                        if (!String.IsNullOrWhiteSpace(Dr["telefone"].ToString()))
                        {
                            var tel = Dr["telefone"].ToString();
                            if (Information.IsNumeric(tel))
                            {
                                item_lista.Telefone = Convert.ToInt64(tel).ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        // throw;
                    }

                    //Adiciona na lista
                    lista.Add(item_lista);
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




        public ClienteLogixDTO PesquisarClientes(String tipo, String valor)
        {
            // var lista = new List<ClienteLogixDTO>();

            var item_lista = new ClienteLogixDTO();

            if (("ID TEL").IndexOf(tipo) > -1)
            {


                try
                {
                    AbrirConexao("Albras");

                    String Str = "Select ";
                    Str += " cod_cliente,";
                    Str += " cnpj,";
                    Str += " cliente,";
                    Str += " endereco,";
                    Str += " bairro,";
                    Str += " cidade,";
                    Str += " uf,";
                    Str += " cep,";
                    Str += " telefone,";
                    Str += " max(email) as email,";
                    Str += " situacao";
                    Str += "  FROM";
                    Str += " (Select  Trim(a.cod_cliente) As cod_cliente, Trim(a.num_cgc_cpf) AS cnpj, Trim(a.nom_cliente) AS cliente,";
                    Str += " Trim(a.end_cliente) AS endereco, Trim(a.den_bairro) AS bairro,";
                    Str += "  Trim(b.den_cidade) AS cidade,";
                    Str += "  trim(b.cod_uni_feder) AS uf,";
                    Str += "  trim(a.cod_cep) AS cep,";
                    Str += " a.num_telefone AS telefone,";
                    Str += " coalesce(e.correio_eletronico, \"\") AS email, a.ies_situacao AS situacao";
                    Str += "  FROM clientes a ";
                    Str += "  INNER JOIN cidades b  ON b.cod_cidade = a.cod_cidade";
                    Str += "  INNER JOIN uni_feder c   ON c.cod_uni_feder = b.cod_uni_feder";
                    Str += "  INNER JOIN paises d     ON d.cod_pais = c.cod_pais";
                    Str += " INNER JOIN vdp_cli_fornec_cpl e      ON e.cliente_fornecedor = a.cod_cliente";
                    Str += " ORDER BY a.cod_cliente) tab_cliente";

                    Str += "  WHERE ";

                    if (tipo == "ID")
                    {
                        Str += "    cod_cliente = '" + valor + "'";
                    }
                    else
                    {
                        Str += "    telefone = '" + valor + "'";
                    }


                    Str += "  GROUP BY ";
                    Str += "  cod_cliente,";
                    Str += " cnpj,";
                    Str += " cliente,";
                    Str += " endereco,";
                    Str += " bairro,";
                    Str += " cidade,";
                    Str += " uf,";
                    Str += " cep,";
                    Str += " telefone,";
                    Str += " situacao";








                    using (Cmd = new System.Data.Odbc.OdbcCommand(Str, Con))
                    {


                        Dr = Cmd.ExecuteReader();


                        if (Dr.Read())
                        {

                            try
                            {
                                //   var item_lista = new ClienteLogixDTO();

                                item_lista.Id_cliente = Convert.ToString(Dr["cod_cliente"]).Trim();
                                item_lista.Cliente = Convert.ToString(Dr["cliente"]).Trim();
                                item_lista.Cnpj = Convert.ToString(Dr["cnpj"]).Trim();
                                item_lista.Email = Convert.ToString(Dr["email"]).Trim();

                                try
                                {

                                    if (!String.IsNullOrWhiteSpace(Dr["telefone"].ToString()))
                                    {
                                        var tel = Dr["telefone"].ToString()
                                            .Replace(".", "")
                                            .Replace("-", "")
                                            .Replace("(", "")
                                            .Replace(")", "")
                                            .Replace(" ", "")
                                            .Replace(",", "");
                                        if (Information.IsNumeric(tel))
                                        {
                                            item_lista.Telefone = Convert.ToInt32(tel).ToString();
                                        }
                                    }
                                }
                                catch (Exception)
                                {

                                    //hrow;
                                }
                                //item_lista.Telefone = Convert.ToString(Dr["telefone"]).Trim();


                                item_lista.Cidade = Convert.ToString(Dr["cidade"]).Trim();
                                item_lista.Estado = Convert.ToString(Dr["uf"]).Trim();
                                item_lista.Bairro = Convert.ToString(Dr["bairro"]).Trim();

                                item_lista.Endereco = Convert.ToString(Dr["endereco"]).Trim();
                                item_lista.Cep = Convert.ToString(Dr["cep"]).Trim();
                                item_lista.Situacao = Convert.ToString(Dr["situacao"]).Trim();

                                //Adiciona na lista
                                //  lista.Add(item_lista);
                            }
                            catch (Exception ex)
                            {

                                var err = ex;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {


                    LogEvento.EscreverEvento("Erro em pesquisar Cliente ligix repository: " + ex.Message.ToString(), MessageType.Error);

                }
                finally
                {
                    FecharConexao();
                }


            }
            return item_lista;
        }


        public List<ClienteLogixDTO> ListarClienteLogix(String nome)
        {


            var lista = new List<ClienteLogixDTO>();




            try
            {
                AbrirConexao("Albras");

                String Str = " Select  Trim(a.cod_cliente) As cod_cliente,";
                Str += " Trim(a.num_cgc_cpf) AS cnpj,";
                Str += " Trim(a.nom_cliente) AS cliente,";
                Str += " Trim(a.end_cliente) AS endereco, ";
                Str += " Trim(a.den_bairro) AS bairro,";
                Str += " a.num_telefone AS telefone";

                Str += "  FROM clientes a ";

                if (!string.IsNullOrEmpty(nome))
                {
                    Str += $" WHERE  Trim(a.nom_cliente) like '%{nome}%' ";
                }

                Str += " ORDER BY a.cod_cliente";


                using (Cmd = new System.Data.Odbc.OdbcCommand(Str, Con))
                {


                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {

                        try
                        {
                            //   var item_lista = new ClienteLogixDTO();
                            var item_lista = new ClienteLogixDTO();
                            item_lista.Id_cliente = Convert.ToString(Dr["cod_cliente"]).Trim();
                            item_lista.Cliente = Convert.ToString(Dr["cliente"]).Trim();
                            item_lista.Cnpj = Convert.ToString(Dr["cnpj"]).Trim();
                            try
                            {

                                if (!String.IsNullOrWhiteSpace(Dr["cnpj"].ToString()))
                                {
                                    var cnpj = Dr["cnpj"].ToString()
                                        .Replace(".", "")
                                        .Replace("-", "")
                                        .Replace("(", "")
                                        .Replace(")", "")
                                        .Replace(" ", "")
                                         .Replace("/", "")
                                        .Replace(",", "");
                                   
                                        item_lista.Telefone =cnpj;
                                   
                                }
                            }
                            catch (Exception ex)
                            {

                                var t = ex;
                            }
                            try
                                {

                                if (!String.IsNullOrWhiteSpace(Dr["telefone"].ToString()))
                                {
                                    var tel = Dr["telefone"].ToString()
                                        .Replace(".", "")
                                        .Replace("-", "")
                                        .Replace("(", "")
                                        .Replace(")", "")
                                        .Replace(" ", "")
                                        .Replace(",", "");
                                    if (Information.IsNumeric(tel))
                                    {
                                        item_lista.Telefone = Convert.ToInt64(tel).ToString();
                                    }
                                }
                                else
                                {
                                    item_lista.Telefone = "00000000";
                                }
                            }
                            catch (Exception ex)
                            {
                                var err = ex;
                            }
                            //item_lista.Telefone = Convert.ToString(Dr["telefone"]).Trim();


                                                      
                            item_lista.Bairro = Convert.ToString(Dr["bairro"]).Trim();

                            item_lista.Endereco = Convert.ToString(Dr["endereco"]).Trim();
                     
                       

                            //Adiciona na lista
                            lista.Add(item_lista);
                        }
                        catch (Exception ex)
                        {

                            var err = ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em listar clientes logix repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }


            return lista;


                                 
                    }

    }
}
