using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Repository;
using Xunit;

namespace VirtuaConecta.Outbound.UnitTest
{
    public class TestaReceitaWs
    {
        [Fact]
        public void TetmQueRetornarDadosCnpj()
        {
            ReceitaRepository _resp = new ReceitaRepository();

            _resp.BuscarInfoReceita("07753605000100");

        }
    }
}
