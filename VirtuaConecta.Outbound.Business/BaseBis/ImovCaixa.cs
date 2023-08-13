using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
   public interface ImovCaixa
    {

        List<CaixaDTO> ListarCaixa();
        Int32 StatusMovCaixa();
        void AlteraStatusCaixa(Int32 ItemIndex, String ItemDescricao, String Valor);
        Int32 CapturaUltimoCodigo();
        List<MovCaixaDTO> ListarMovCaixa();
        string ExecutarVendaCaixa(List<PedidoDTO> pedido, TicketDTO ticket, MovCaixaDTO movimento);
        List<Rep_mov_caixa> GetReport(String dtIni, String dtFim);
        MovCaixaDTO PesquisaTicket(Int32 id_ticket);
        String TotaisFechamento(String dtIni, String dtFim);
    }
}
