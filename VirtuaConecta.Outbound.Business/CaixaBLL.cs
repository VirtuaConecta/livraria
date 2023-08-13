using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Repository;
using VirtuaConecta.Outbound.Repository.BaseRepo;

namespace VirtuaConecta.Outbound.Business
{

   public class CaixaBLL: BaseBis.IcaixaBLL
    {
        IdataConections _db;
        public CaixaBLL()
        {
            _db = Factory.CriaConexao();
        }


        public String ExecutaVenda(List<PedidoDTO> pedido, TicketDTO ticket, MovCaixaDTO movimento)
        {

            return _db.InsereVenda(pedido,ticket,movimento);
        }

    }

  
}
