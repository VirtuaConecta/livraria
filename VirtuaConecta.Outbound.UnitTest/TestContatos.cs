using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Model;
using Xunit;

namespace VirtuaConecta.Outbound.UnitTest
{
    public class TestContatos
    {


        [Fact]

        public void TemQueRetornarListaHistorico()
        {
            ContatosBLL _contato = new ContatosBLL();


            var lista = _contato.ListaHistoricoContato(10);


        }

        [Fact]
        public void TemQueRetornarListaDiferenca()
        {
            ContatosBLL _contato = new ContatosBLL();


          _contato.AtualizaListaContato("90");


        }


        [Fact]
        public void TemQueAtualizardadosFinanceirosListaLocal()
        {
            ContatosBLL _contato = new ContatosBLL();

            var contato = new ContatosDTO();

            contato.Id_cliente = "60633";
            // contato.Dias_sem_compra = 1000;
            contato.Mes_Maior_compra = DateTime.Now.AddDays(-30);

            _contato.AtualizaInfoFinanceira(contato.Id_cliente);


        }
    }
}
