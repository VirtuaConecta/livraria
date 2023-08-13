using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Repository
{
    public class Conexao_Mysql
    {
     
        protected MySqlConnection Con; // faz a conexao
        protected MySqlCommand Cmd; // Escrever ou executar comanados
        protected MySqlDataReader Dr; //guarda regustros obtidos de querys

        protected MySqlDataAdapter Da;
        //abrir conexao

        protected void AbrirConexao()
        {
            try
            {
                //Local
                string path = Parametros.Parametros.LocalDbMysql();

                //Servidor
                // string path = "10.0.0.172";

                //String de conexão
                Con = new MySqlConnection("server=" + path + ";port=3306;user id=root;password=123456;persistsecurityinfo=True;database=virtua_tlmk");
                //Con = new MySqlConnection(" Server = " + path + "; Port = 3306; Database = virtua; Uid = root; Pwd = 123456;");

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
