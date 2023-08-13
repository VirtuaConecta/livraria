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
    public class FiltroConsultaRepository : Conexao_Mysql, BaseRepo.IfiltroDAL
    {


        public List<FiltrosDTO> ListarFiltros()
        {
            var lista = new List<FiltrosDTO>();


            try
            {
                AbrirConexao();


                String Str = " SELECT ";
                Str += " id,";
                Str += " cod_filtro,";
                Str += " descricao,";
                Str += " `sql` ";


                Str += " FROM tab_filtro";



                using (Cmd = new MySqlCommand(Str, Con))
                {

                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new FiltrosDTO();

                        item_lista.Id = Convert.ToInt32(Dr["id"]);
                        item_lista.Cod_Filtro = Convert.ToString(Dr["cod_filtro"]);
                        item_lista.Descricao = Convert.ToString(Dr["descricao"]);
                        item_lista.Sql = Convert.ToString(Dr["sql"]);

                        //Adiciona na lista
                        lista.Add(item_lista);
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em ListarFiltros repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }




            return lista;






        }


        public String EditarFiltro(FiltrosDTO item)
        {
            String resp = "OK";

            try
            {
                String str = "UPDATE tab_filtro SET ";
                str += " `descricao` = @vNome,";
                str += " `sql`= @vSql ";
                str += " WHERE id= @vId";
                AbrirConexao();
                using (Cmd = new MySqlCommand(str, Con))
                {

                    Cmd.CommandText = str;
                    Cmd.Parameters.AddWithValue("@vId", item.Id);
                    Cmd.Parameters.AddWithValue("@vNome", item.Descricao);
                    Cmd.Parameters.AddWithValue("@vSql", @item.Sql);
                    Cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {
                resp = "Erro";
                LogEvento.EscreverEvento("Erro em EditarFiltro repository: " + ex.Message.ToString(), MessageType.Error);
            }

            finally
            {
                FecharConexao();
            }

            return resp;
        }


        public String InserirFiltro(FiltrosDTO item)
        {
            String resp = "OK";

            try
            {
                String str = "INSERT INTO tab_filtro (`descricao`,`sql`) ";
                str += "VALUES ( @vNome,";
                str += " @vSql )";
               
                AbrirConexao();
                using (Cmd = new MySqlCommand(str, Con))
                {

                    Cmd.CommandText = str;
                   
                    Cmd.Parameters.AddWithValue("@vNome", item.Descricao);
                    Cmd.Parameters.AddWithValue("@vSql", @item.Sql);
                    Cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {
                resp = "Erro";
                LogEvento.EscreverEvento("Erro em inserir filtro repository: " + ex.Message.ToString(), MessageType.Error);
            }

            finally
            {
                FecharConexao();
            }

            return resp;
        }
    }
}
