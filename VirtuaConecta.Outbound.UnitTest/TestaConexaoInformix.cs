using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Repository;
using Xunit;

namespace VirtuaConecta.Outbound.UnitTest
{
    public class TestaConexaoInformix
    {


        [Fact]

        public void TequeTemqueConectarInformix()
        {

            ClienteInformixRepository _conn = new ClienteInformixRepository();

            var lista = _conn.ListarStatusContatos("90",null);


            Assert.True(lista.Count>0);

        }
    }
}
