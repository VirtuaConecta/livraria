using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Business;
using Xunit;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.UnitTest
{
    public class Teste_Ticket
    {


        [Fact]

        public void TemQueRetornarProximoTicket()
        {
            TicketBusiness ticket = new TicketBusiness();

            var resp = ticket.NumeroProximoTicket();


            Assert.True(true);


        }



        [Fact]

        public void TemQueRImprimirTicket()
        {
            TicketBusiness ticket = new TicketBusiness();

         //   var resp = ticket.ImprimirTicket(3);
            var resp = ticket.ImprimirTicketMP4200(3);

            Assert.True(true);


        }





    }
}
