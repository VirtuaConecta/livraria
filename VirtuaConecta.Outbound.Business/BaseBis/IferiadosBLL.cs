using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IferiadosBLL
    {
        List<FeriadoDTO> PesquisaFeriados(Int32 ano, String Estado, String Cidade, Int32? codMun);
    }
}
