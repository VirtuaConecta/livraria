using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IpedidoBLL
    {

        List<PedidoDTO> PesquisaPedido(Int32 id_ticket);
    }
}
