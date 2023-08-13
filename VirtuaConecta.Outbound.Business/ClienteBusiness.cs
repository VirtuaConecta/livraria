using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Business.BaseBis;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Business
{
    public class ClienteBusiness : IclienteBLL
    {
        Repository.BaseRepo.IdataConections _cliente;
        public ClienteBusiness()
        {
            _cliente = Factory.CriaConexao();
        }

        public List<ClienteDTO> ClienteListar()
        {
            return _cliente.ClienteListar();
        }
        public String ClienteInserir(ClienteDTO cliente)
        {
            return _cliente.ClienteInserir(cliente);
        }
        public String ClienteEditar(ClienteDTO cliente)
        {
            return _cliente.ClienteEditar(cliente);
        }

        public List<ClienteHistoricoDTO> ClienteHistoricoListar()
        {
            return _cliente.ClienteHistoricoListar();
        }



        
    }
}
