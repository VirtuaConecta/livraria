using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Repository.BaseRepo;

namespace VirtuaConecta.Outbound.Business
{
    public class PedidoBusiness: BaseBis.IpedidoBLL
    {



        IdataConections _db;

        public PedidoBusiness()
        {
            _db = Factory.CriaConexao();


        }

        public List<PedidoDTO> PesquisaPedido(Int32 id_ticket) { 


            var pedido = _db.ListarPedido().Where(x => x.Id_ticket == id_ticket).ToList();
         


            return pedido;

        }

    }
}
