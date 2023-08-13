using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IclienteBLL
    {
        List<ClienteDTO> ClienteListar();
        String ClienteEditar(ClienteDTO cliente);
        String ClienteInserir(ClienteDTO cliente);
        List<ClienteHistoricoDTO> ClienteHistoricoListar();
       
    }
}
