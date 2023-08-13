using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
   public interface ClienteLogixBLL
    {
        List<ClienteLogixDTO> ListaClienteLogix(String nome);
    }
}
