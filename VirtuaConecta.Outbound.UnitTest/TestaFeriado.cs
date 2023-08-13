using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Utility;
using Xunit;

namespace VirtuaConecta.Outbound.UnitTest
{
    public class TestaFeriado
    {
        [Fact]
        public void TemQueRetornarFeriado()
        {
            var _iferiado = new FeriadosBLL();
            DateTime DtEntrega;

            var resData = Conversoes.StringToDate("24/01/2019", "dd/mm/yyyy");

            DtEntrega = Convert.ToDateTime("24/01/2019").AddDays(1);

            if (Information.IsNumeric("3550308"))
            {
                var ibge = Convert.ToInt32("3550308");

                var data_feriado = _iferiado.PesquisaFeriados(DtEntrega.Year, null, null, ibge).Where(x => Conversoes.StringToDate(x.date, "dd/mm/yyyy") == DtEntrega).FirstOrDefault();
                //Verifica se é feriado
                if (!String.IsNullOrEmpty(data_feriado.date))
                {
                    if (data_feriado.type_code !="9")
                    {
                        DtEntrega = DtEntrega.AddDays(1);
                    }
                  


                    String msg = String.Format(@"Dia {0} é Feriado\r\n Comemora {1}\r\n Tipo {2}", data_feriado.date, data_feriado.name, data_feriado.type);


                }
            }

        


        }


        [Fact]
        public void TemQueRetornarDataPervista()
        {
            var _contato =new ContatosBLL();
            var ibge ="3550308";
            var dataRet = Convert.ToDateTime("2019-06-12");

            var resp = _contato.DataProxContato(dataRet,ibge);

        }


    }
}
