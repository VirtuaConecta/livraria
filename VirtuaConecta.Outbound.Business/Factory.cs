using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Repository;
using VirtuaConecta.Outbound.Repository.BaseRepo;

namespace VirtuaConecta.Outbound.Business
{
    public class Factory
    {

        public static ContatosBLL CriarContatosBLL()
        {
            return new ContatosBLL();
        }

        public static FornecedorBLL CriarFornecedorBll()
        {
            return new FornecedorBLL();
        }
        public static EstoqueBll CriaEstoqueBll()
        {
            return new EstoqueBll();
        }
        public static MovCaixaBusiness CriaMovCaixa()
        {
            return new MovCaixaBusiness();
        }

        public static MeioPagtoBLL CriaMeioPagtoBLL()
        {
            return new MeioPagtoBLL();
        }
        public static ContatosRepository CriarContatosDAL()
        {
            return new ContatosRepository();
        }
        public static PedidoBusiness CriaPedidoBLL()
        {

            return new PedidoBusiness();
        }

        public static CaixaBLL CriaCaixaBLL()
        {
            return new CaixaBLL();
        }
        public static TicketBusiness CriarTicketBLL()
        {
            return new TicketBusiness();
        }

        public static FeriadosRepository CriaFeriadoDal()
        {
            return new FeriadosRepository();
        }
        public static FeriadosBLL CriaFeriadoBLL()
        {
            return new FeriadosBLL();
        }
        public static ReceitaRepository CriarReceitaDAL()
        {
            return new ReceitaRepository();
        }

        public static ReceitaBLL CriarReceitaBLL()
        {
            return new ReceitaBLL();
        }
        public static CorreiosRepository CriarCorreioDAL()
        {
            return new CorreiosRepository();
        }

        public static CorreiosBusiness CriarCorreioBLL()
        {
            return new CorreiosBusiness();
        }

        public static FiltroConsultaRepository CriarFiltroDAL()
        {
            return new FiltroConsultaRepository();
        }

        public static FiltrosConsultaBusiness CriarFiltroBLL()
        {
            return new FiltrosConsultaBusiness();
        }

        public static ClienteInformixRepository CriarConatoInfomixDAL()
        {
            return new ClienteInformixRepository();
        }

        public static ClienteLogixBLL CriarClienteLogix()
        {

            return new ClienteLogixBLL();

        }

        public static ReportsRepository CriaReportDal()
        {
            return new ReportsRepository();

        }
        public static ReportsBLL CriaReportBll()
        {
            return new ReportsBLL();

        }


        public static ListaConfigContatoRepository CriaConfigListaDAL()
        {
            return new ListaConfigContatoRepository();
        }

        public static ListaConfigContatoBLL CriaConfigListaBLL()
        {
            return new ListaConfigContatoBLL();
        }

        public static Consultas_Sqlite CriaConexao()
        {
            return new Consultas_Sqlite();
        }

        public static UsuariosBusiness CriaUsuarioBLL()
        {
            return new UsuariosBusiness();
        }


        public static CarteirasRepository CriaCarteiraDAL()
        {

            return new CarteirasRepository();
        }

        public static CarteirasBusiness CriaCarteiraBLL()
        {

            return new CarteirasBusiness();
        }


        public static ProdutoBusiness CriaProdutoBLL()
        {

            return new ProdutoBusiness();
        }
        public static ClienteBusiness CriaClienteBLL()
        {

            return new ClienteBusiness();
        }
    }
}
