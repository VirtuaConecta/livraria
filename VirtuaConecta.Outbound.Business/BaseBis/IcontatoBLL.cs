using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
   public interface IcontatoBLL
    {

        List<ContatosDTO> ListaContatos(String filtro);
        List<StatusContatoDTO> ListaStatusContatos();
        List<HistoricoDTO> ListaHistoricoContato(Int32? id);
        String AtualizaContato(ContatosDTO item);
            String InsereHistorico(HistoricoDTO item);
        DataRetorno DataProxContato(DateTime DtEntrega, String CodMun);
        String AtualizaListaContato(String days);
        String InsereContatosBulk(List<ContatosDTO> lista);

        String AtualizaDadoFAturamento(ContatosDTO item);
        void AtualizaInfoFinanceira(String id_cliente);
        String BloqueiaContato(int Id, int st, String operador);
        String InsereContatosUnit(ContatosDTO item);
        List<HistoricoDTO> HistoricoAgrupadoBll(String dt_in, String dt_fim, String opera);
        List<ContatosDTO> ListaEnvioCorreio();
    }
}
