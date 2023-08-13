using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
    public interface IfiltroDAL
    {

        List<FiltrosDTO> ListarFiltros();
        String EditarFiltro(FiltrosDTO item);
        String InserirFiltro(FiltrosDTO item);
    }
}
