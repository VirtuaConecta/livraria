using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Repository;
using Xunit;

namespace VirtuaConecta.Outbound.UnitTest
{
    public class TestaCorreio
    {

        [Fact]

        public void temQueRetornarData()
        {
            CorreiosRepository corr = new CorreiosRepository();

            corr.CalcularPrazoRastreio("40010","05525080", "12223000");

        }


        [Fact]

        public void temQueRetornarEndereco()
        {
            CorreiosRepository corr = new CorreiosRepository();

            var resp = corr.PesquisarCep("12223000");

        }



        [Fact]
        public void temQueretornarRastreio2()
        {
            CorreiosRepository corr = new CorreiosRepository();

             corr.RatrearEncomenda("PM574204336BR");

        }
    }
}
