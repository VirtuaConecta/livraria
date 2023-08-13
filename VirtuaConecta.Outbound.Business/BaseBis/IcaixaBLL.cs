using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IcaixaBLL
    {
        String ExecutaVenda(List<PedidoDTO> pedido, TicketDTO ticket, MovCaixaDTO movimento);
    }
}
