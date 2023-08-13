using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business
{
    public class FiltrosConsultaBusiness : BaseBis.IfiltroBLL
    {
        private Repository.BaseRepo.IfiltroDAL _ifiltro;
        public FiltrosConsultaBusiness()
        {
            _ifiltro = Factory.CriarFiltroDAL();
        }
        public List<FiltrosDTO> ListaFiltros()
        {
            return _ifiltro.ListarFiltros();
        }

        public static string ValidarFIltro(FiltrosDTO item)
        {
            String resp = "OK";

            if (String.IsNullOrEmpty(item.Descricao))
            {
                resp = "Inserir um nome para o Filtro";
            }
            else if (String.IsNullOrEmpty(item.Sql))
            {
                resp = "Inserir Filtro Sql";
            }

            return resp;
        }

        public string EditaFiltro(FiltrosDTO item)
        {
            return _ifiltro.EditarFiltro(item);
        }

        public string InsereFiltro(FiltrosDTO item)
        {
            return _ifiltro.InserirFiltro(item);
        }
    }
}
