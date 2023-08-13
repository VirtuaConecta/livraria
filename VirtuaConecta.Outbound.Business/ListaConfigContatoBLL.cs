using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business
{
   public  class ListaConfigContatoBLL: BaseBis.iconfBLL
    {

        Repository.BaseRepo.iconfDAL _iconfig;
        public ListaConfigContatoBLL()
        {
            _iconfig = Factory.CriaConfigListaDAL();
        }

        public string ApagaConfContato(string item)
        {
            return _iconfig.ApagarConfContato(item);
        }

        public string AtualizaConfContato(ListaConfigContatoDTO item)
        {
            return _iconfig.AtualizarConfContato(item);
        }

        public string InsereConfContato(ListaConfigContatoDTO item_lista)
        {
            return _iconfig.InserirConfContato(item_lista);
        }

        public List<ListaConfigContatoDTO> ListaConfContato()
        {
            return _iconfig.ListarConfContato();
        }
    }
}
