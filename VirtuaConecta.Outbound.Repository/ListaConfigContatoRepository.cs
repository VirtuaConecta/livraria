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
    public class ListaConfigContatoRepository: Conexao_Mysql,BaseRepo.iconfDAL
    {

        public String InserirConfContato(ListaConfigContatoDTO item)
        {
            String retorno = "OK";
            try
            {
                AbrirConexao();

                String Sql = "INSERT INTO tab_configura_lista ";
                Sql += " (`operador`,";
                Sql += " `carteiras`,";
                Sql += " `sequencias`,";
                Sql += " `prioridades`,";
                Sql += " `nao_cancelados`,";
                Sql += " `dias_sem_compra`)";

                Sql += " VALUES (";
                Sql += "@operador,";
                Sql += "@carteiras,";
                Sql += "@sequencia,";
                Sql += "@prioridade,";
                Sql += "@nao_cancelados,";
                Sql += "@dias_sem_compra)";


                using (Cmd = new MySqlCommand(Sql, Con))
                {
                    Cmd.CommandText = Sql;

                    Int32 cancela = 0;
                    if (item.Nao_cancelados)
                    {
                        cancela = 1;
                    }

                    Cmd.Parameters.AddWithValue("@operador", item.Operador);
                    Cmd.Parameters.AddWithValue("@carteiras", item.Carteiras);
                    Cmd.Parameters.AddWithValue("@sequencia", item.Sequencia);
                    Cmd.Parameters.AddWithValue("@prioridade", item.Prioridades);

                    Cmd.Parameters.AddWithValue("@nao_cancelados", cancela);
                    Cmd.Parameters.AddWithValue("@dias_sem_compra", item.Dias_sem_Compras);



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
        public List<ListaConfigContatoDTO> ListarConfContato()
        {
            var lista = new List<ListaConfigContatoDTO>();


            try
            {
                AbrirConexao();


                String Str = " SELECT ";
                Str += " `tab_configura_lista`.`operador`,";
                Str += " `tab_configura_lista`.`carteiras`,";
                Str += " `tab_configura_lista`.`sequencias`,";
                Str += " `tab_configura_lista`.`prioridades`,";

                Str += " `tab_configura_lista`.`nao_cancelados`,";
                Str += " `tab_configura_lista`.`dias_sem_compra`";

                Str += " FROM `virtua_tlmk`.`tab_configura_lista`";


                using (Cmd = new MySqlCommand(Str, Con))
                {
                 
                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new ListaConfigContatoDTO();

                        item_lista.Operador = Convert.ToString(Dr["operador"]);
                        item_lista.Carteiras = Convert.ToString(Dr["carteiras"]);
                        item_lista.Prioridades = Convert.ToString(Dr["prioridades"]);
                        item_lista.Sequencia = Convert.ToString(Dr["sequencias"]);

                        item_lista.Nao_cancelados = Convert.ToBoolean(Dr["nao_cancelados"]);
                        item_lista.Dias_sem_Compras = Convert.ToInt32(Dr["dias_sem_compra"]);


                        //Adiciona na lista
                        lista.Add(item_lista);
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em ListarConfContato repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }




            return lista;
        }
        public String AtualizarConfContato(ListaConfigContatoDTO item)
        {
            String retorno = "OK";
            try
            {
                AbrirConexao();

                String Str = "UPDATE  tab_configura_lista SET ";

                Str += " carteiras=@carteiras,";
                Str += " sequencias=@sequencia,";
                Str += " prioridades=@prioridade,";

                Str += " nao_cancelados=@nao_cancelados,";
                Str += " dias_sem_compra=@dias_sem_compra";



                Str += " WHERE operador=@vId";


                using (Cmd = new MySqlCommand(Str, Con))
                {
                    Cmd.CommandText = Str;
                    Cmd.Parameters.AddWithValue("@vId", item.Operador);
                    Cmd.Parameters.AddWithValue("@carteiras", item.Carteiras);
                    Cmd.Parameters.AddWithValue("@sequencia", item.Sequencia);
                    Cmd.Parameters.AddWithValue("@prioridade", item.Prioridades);

                    Cmd.Parameters.AddWithValue("@nao_cancelados", item.Nao_cancelados);
                    Cmd.Parameters.AddWithValue("@dias_sem_compra", item.Dias_sem_Compras);


                    Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                retorno = "Erro";
                LogEvento.EscreverEvento("Erro AtualizarConfContato repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }


            return retorno;

        }


     public String ApagarConfContato(String item)
    {
        String retorno = "OK";
        try
        {
            AbrirConexao();

            String Str = "DELETE FROM `virtua_tlmk`.`tab_configura_lista` ";

            Str += " WHERE operador=@vId";


            using (Cmd = new MySqlCommand(Str, Con))
            {
                Cmd.CommandText = Str;
                Cmd.Parameters.AddWithValue("@vId", item);
               
                Cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            retorno = "Erro";
            LogEvento.EscreverEvento("Erro AtualizarConfContato repository: " + ex.Message.ToString(), MessageType.Error);

        }
        finally
        {
            FecharConexao();
        }


        return retorno;

    }
}
}
