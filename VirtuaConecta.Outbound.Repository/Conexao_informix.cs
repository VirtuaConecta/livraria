using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Utility;

using VirtuaConecta.Outbound.Parametros;
using System.Data.Odbc;
namespace VirtuaConecta.Outbound.Repository
{
    public class Conexao_informix
    {
        
        protected OdbcConnection Con; // faz a conexao
        protected OdbcCommand Cmd; // Escrever ou executar comanados
        protected OdbcDataReader Dr; //guarda regustros obtidos de querys

        protected OdbcDataAdapter Da;
        //abrir conexao


        protected void AbrirConexao(String dns)
        {
            try
            {

                ////Local
                //string SERVICENUM = "1580";
                ////Servidor
                //// string path = "10.0.0.172";
                //String HOST = "10.10.0.36";
                //String SERVER = "albras10";
                //String DATABASE = "logix";
                //String USER = "logix";
                //String PASSWORD = "Tecinfo09";
                ////String de conexão
                //String Str = "Host=" + HOST + "; " +
                //                "Service=" + SERVICENUM + "; " +
                //                 "Server=" + SERVER + "; " +
                //                 "Database=" + DATABASE + "; " +
                //                 "User Id=" + USER + "; " +
                //                 "Password=" + PASSWORD + "; ";



                Con = new OdbcConnection("dsn=" + dns + ";uid=informix;pwd=logix");

                //Con = new MySqlConnection(" Server = " + path + "; Port = 3306; Database = virtua; Uid = root; Pwd = 123456;");
                //   Con.ConnectionTimeout =90;
                Con.Open();


            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("Erro ao conectar ao DB: " + ex.Message.ToString(), MessageType.Error);

            }
        }


        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("EErro ao Desconecta do DB: " + ex.Message.ToString(), MessageType.Error);

            }

        }


    }
}
