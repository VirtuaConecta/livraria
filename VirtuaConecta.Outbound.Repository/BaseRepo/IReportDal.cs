using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
    public interface IReportDal
    {
        object HistoricoRetornoLigacoes(String dt_in, String dt_fim, String opera);
        List<LigacaoMotivoDTO> HistoricoCotacaoVenda(String dt_in, String dt_fim, String opera, int st);

        object HistoricoVendasTotais(String dt_in, String dt_fim, String opera);

        List<HistoricoContatoDTO> HistoricoContatos(String dt_in, String dt_fim, String opera);

        object HistoricoVisaoGeral(String dt_in, String dt_fim, String opera);


    }
}
