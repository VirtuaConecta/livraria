using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
   public interface iconfDAL
    {
        String InserirConfContato(ListaConfigContatoDTO item_lista);
        List<ListaConfigContatoDTO> ListarConfContato();
        String ApagarConfContato(String item);
        String AtualizarConfContato(ListaConfigContatoDTO item);
    }
}
