using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;
using Xunit;

namespace VirtuaConecta.Outbound.UnitTest
{
    public class Teste_logEventos
    {

        [Fact]

        public void temQueInserirNoLog()
        {
            bool resp = false;
            LogEvento.EscreverEvento("teste",MessageType.Error);
            LogEvento.EscreverEvento("teste1", MessageType.Information);
            LogEvento.EscreverEvento("teste2", MessageType.Warning);

            if (Directory.Exists(Parametros.Parametros.LocalLogFile()))
            {
                resp = true;
            }

            Assert.True(resp);
        }


        [Fact]

        public void temAbrirMsgbox()
        {
         //   MsgBox.Show("Lista local atualizada!", "Sucesso", MsgBox.Buttons.OK);
        }

    }
}
