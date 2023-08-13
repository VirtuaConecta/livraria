using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IreportsBll
    {

        List<DashDTO> Db_venda_produtoBll(String dt_in, String dt_fim, String ordem);
        List<DashDTO> Db_venda_familiaBll(String dt_in, String dt_fim);
        List<DashDTO> Db_venda_meioValorBll(String dt_in, String dt_fim);
    }
}
