using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Utility;
using Xunit;

namespace VirtuaConecta.Outbound.UnitTest
{
    public class TestaMascara
    {

        [Fact]
        public void temQueRetornarNrComMascara()
        {
            String tel = "1143816642";
            var mascara = Mask.Telefone(tel);

        }
    }
}
