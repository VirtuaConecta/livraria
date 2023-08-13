using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Utility
{
    public class Arquivos
    {
        public static void EscreveArquivo(String Arq, String body)
        {
            //Declaração do método StreamWriter passando o caminho e nome do arquivo que deve ser salvo
            StreamWriter writer = new StreamWriter(Arq);
            //Escrevendo o Arquivo e pulando uma linha
            writer.WriteLine(body);

            //Fechando o arquivo
            writer.Close();
            //Limpando a referencia dele da memória
            writer.Dispose();
        }

        public static String LeArquivo(String Arq)
        {
            String Body = "";

                try
                {
                    using (var fs = new FileStream(Arq, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    // cria um leitor e abre o arquivo
                    using (var Read = new StreamReader(fs, Encoding.Default))
                    {
                    // StreamReader Read = new StreamReader(Arq);

                    Body = Read.ReadToEnd();
                        Read.Close();
                        Read.Dispose();
                    }

                }
                catch (IOException ex)
                {
                    var err = "Erro em LeArquivo (" + Arq + "): " + ex.Message;

                  //  _log.WriteEntry(err, EventLogEntryType.Error);

                }
          

            return Body;

        }




    }
}
