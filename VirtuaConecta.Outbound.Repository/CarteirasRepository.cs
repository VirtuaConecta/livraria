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
   public class CarteirasRepository: Conexao_Mysql,BaseRepo.IcarteiraDAL
    {

        public List<CarteirasDTO> ListarCarteira()
        {
            var lista = new List<CarteirasDTO>();


            try
            {
                AbrirConexao();


                String Str = " SELECT ";
                Str += " Carteira,";
                Str += " reservado,";
                Str += " usuario";
                Str += " FROM tab_carteiras";



                using (Cmd = new MySqlCommand(Str, Con))
                {

                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new CarteirasDTO();

                        item_lista.Reservado = Convert.ToInt32(Dr["reservado"]);
                        item_lista.Carteira = Convert.ToString(Dr["Carteira"]);
                        item_lista.Usuario = Convert.ToString(Dr["usuario"]);
                        //Adiciona na lista
                        lista.Add(item_lista);
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em Listar carteiras repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }




            return lista;






        }


        public String EditarCarteira(CarteirasDTO item)
        {
            String resp = "OK";

            try
            {
                String str = "UPDATE tab_carteiras SET ";
                str += " `reservado` = @reservado,";
                str += " `usuario` = @usuario";
                str += " WHERE carteira= @carteira";
                AbrirConexao();
                using (Cmd = new MySqlCommand(str, Con))
                {

                    Cmd.CommandText = str;
                    Cmd.Parameters.AddWithValue("@reservado", item.Reservado);
                    Cmd.Parameters.AddWithValue("@carteira", item.Carteira);
                    Cmd.Parameters.AddWithValue("@usuario", item.Usuario);
                    Cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {
                resp = "Erro";
                LogEvento.EscreverEvento("Erro em editar carteira repository: " + ex.Message.ToString(), MessageType.Error);
            }

            finally
            {
                FecharConexao();
            }

            return resp;
        }


        public String InserirCarteira(CarteirasDTO item)
        {
            String resp = "OK";

            try
            {
                String str = "INSERT INTO tab_carteiras (`carteira`,`reservado`) ";
                str += "VALUES ( @carteira,";
                str += " 0 )";

                AbrirConexao();
                using (Cmd = new MySqlCommand(str, Con))
                {

                    Cmd.CommandText = str;

                    Cmd.Parameters.AddWithValue("@carteira", item.Carteira);
                
                    Cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {
                resp = "Erro";
                LogEvento.EscreverEvento("Erro em inserir carteira repository: " + ex.Message.ToString(), MessageType.Error);
            }

            finally
            {
                FecharConexao();
            }

            return resp;
        }


        public String ApagarCarteiraPorUsuario(String Usuario )
        {
            String resp = "OK";

            try
            {
                String str = "UPDATE tab_carteiras SET ";

                    str += " `reservado` =0,";
                    str += " `usuario` = NULL";
              
              
                str += " WHERE usuario= @usuario";
                AbrirConexao();
                using (Cmd = new MySqlCommand(str, Con))
                {

                    Cmd.CommandText = str;

                    Cmd.Parameters.AddWithValue("@usuario", Usuario);
                    Cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {
                resp = "Erro";
                LogEvento.EscreverEvento("Erro em editar carteira repository: " + ex.Message.ToString(), MessageType.Error);
            }

            finally
            {
                FecharConexao();
            }

            return resp;
        }
    }
}
