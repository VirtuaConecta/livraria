using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
    public interface IcontatoDAL
    {
        List<ContatosDTO> ListarContatos(String filtro);
        List<StatusContatoDTO> ListarStatusContatos();
        String InserirHistorico(HistoricoDTO item);
        List<HistoricoDTO> ListarHistoricoContato(Int32? id);
        String AtualizarContato(ContatosDTO item);
        String InserirContatosBulk(List<ContatosDTO> lista);
        String AtualizarDadoFAturamento(ContatosDTO item);
        String BloqueiarContato(int Id, int st, String operador);
        String InserirContatosUnit(ContatosDTO item);
        List<HistoricoDTO> HistoricoAgrupado(String dt_in, String dt_fim, String opera);
        List<ContatosDTO> ListarEnvioCorreio();
    }
}
