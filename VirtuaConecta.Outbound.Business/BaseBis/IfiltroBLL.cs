using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IfiltroBLL
    {
        List<FiltrosDTO> ListaFiltros();
        String EditaFiltro(FiltrosDTO item);
        String InsereFiltro(FiltrosDTO item);
    }
}
