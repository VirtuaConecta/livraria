using Newtonsoft.Json;
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
   public class TestaReports
    {

        [Fact]
        public void TemQueRetornarListaHistoricoCOntato()
        {
            var dt_in = "2020-01-10";
            var dt_fim = "2020-01-15";
            String opera = "Todos";
            ReportsBLL _report = new ReportsBLL();

        //    var resp = _report.HistoricoContatosBll(dt_in, dt_fim, opera);



        }


        [Fact]
        public void TemQueRetornarReportGeral()
        {
            var dt_in = "2020-01-01";
            var dt_fim = "2020-01-19";
            String opera = "Todos";
            ReportsBLL _report = new ReportsBLL();

        //    object obj = _report.HistoricoVisaoGeralBll(dt_in, dt_fim, opera);

         
            //var outros =Conversoes.GetValObjBy(obj, "Tota_Outros");
            //var vendas = Conversoes.GetValObjBy(obj, "Total_Vendas");
            //var cotacoes = Conversoes.GetValObjBy(obj, "Total_Contacao");
        }
    }

   
}
