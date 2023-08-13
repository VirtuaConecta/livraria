using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IcarteiraBLL
    {
        List<CarteirasDTO> ListaCarteira();
        String EditaCarteira(CarteirasDTO item);
        String InsereCarteira(CarteirasDTO item);
        List<CarteirasDTO> ListaCarteiraDiponivel();
        String ApagaCarteiraPorUsuario(String Usuario);
    }
}
