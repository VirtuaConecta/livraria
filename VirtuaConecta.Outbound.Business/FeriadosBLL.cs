using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Repository;
namespace VirtuaConecta.Outbound.Business
{
    public class FeriadosBLL : BaseBis.IferiadosBLL
    {
        private Repository.BaseRepo.IferiadoDAL _iferiado;
        public FeriadosBLL()
        {
            _iferiado = Factory.CriaFeriadoDal();
        }


        public List<FeriadoDTO> PesquisaFeriados(Int32 ano, string Estado, string Cidade, int? codMun)
        {
            return _iferiado.PesquisarFeriados(ano, Estado, Cidade, codMun);
        }
    }
}
