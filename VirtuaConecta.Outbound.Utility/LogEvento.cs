using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Parametros;

namespace VirtuaConecta.Outbound.Utility
{
    public class LogEvento
    {




      public  static void EscreverEvento(String msg, String tipo)
        {
            String nome_Arq = "Log_outbound.txt";

            if (!Directory.Exists(Parametros.Parametros.LocalLogFile()))
            {
                Directory.CreateDirectory(Parametros.Parametros.LocalLogFile());
            }





            using (var log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                 .WriteTo.File(Parametros.Parametros.LocalLogFile() +"\\"+ nome_Arq, rollingInterval: RollingInterval.Day)
                .CreateLogger())
            {

                if (tipo == "Info")
                {
                    log.Information(msg);
                }
                else if (tipo == "Aviso")
                {
                    log.Warning(msg);
                }
                else if (tipo == "Erro")
                {
                    log.Error(msg);
                }



            }
        }


    }
}
