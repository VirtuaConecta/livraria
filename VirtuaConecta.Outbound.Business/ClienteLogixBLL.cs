using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business
{
    public class ClienteLogixBLL : BaseBis.ClienteLogixBLL
    {
        private Repository.BaseRepo.IcontatoInformix _cliente;
        public ClienteLogixBLL()
        {
            _cliente = Factory.CriarConatoInfomixDAL();
        }
        public List<ClienteLogixDTO> ListaClienteLogix(String nome)
        {
            return _cliente.ListarClienteLogix(nome);
        }
    }
}
