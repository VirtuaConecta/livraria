using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IticketBLL
    {
        List<TicketDTO> ListaTickets();
        String NumeroProximoTicket();
        String InserirTicket(TicketDTO ticket);
        String ImprimirTicketMP4200(Int32 id_tickect);
        String ImprimirTicket(Int32 id_tickect);
    }
}
