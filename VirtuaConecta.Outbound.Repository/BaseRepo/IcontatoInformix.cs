using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
   public interface IcontatoInformix
    {
        ClienteLogixDTO PesquisarClientes(String tipo, String valor);

        List<ContatosDTO> ListarStatusContatos(String dias, String IdCliente);

        List<ClienteLogixDTO> ListarClienteLogix(String nome);

    }
}
