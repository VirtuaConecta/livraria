using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface iconfBLL
    {
        String InsereConfContato(ListaConfigContatoDTO item_lista);
        List<ListaConfigContatoDTO> ListaConfContato();
        String ApagaConfContato(String item);
        String AtualizaConfContato(ListaConfigContatoDTO item);
    }
}
