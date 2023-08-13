using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
    public interface IferiadoDAL
    {
        List<FeriadoDTO> PesquisarFeriados(Int32 ano, String Estado, String Cidade, Int32? codMun);
    }
}
