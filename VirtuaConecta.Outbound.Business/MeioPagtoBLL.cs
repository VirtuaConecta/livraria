using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Repository.BaseRepo;

namespace VirtuaConecta.Outbound.Business
{
    public class MeioPagtoBLL: BaseBis.Imeiopagto
    {
        IdataConections _db;

        public MeioPagtoBLL()
        {
            _db = Factory.CriaConexao();
        }

       
        public List<FormaPagtoDTO> ListarMeioPagto()
        {
            return _db.ListarFormaPagto();
        }
        public String FormaPagtoInserir(FormaPagtoDTO forma)
        {
            return _db.FormaPagtoInserir(forma);
        }
        public String FormaPagtoEditar(FormaPagtoDTO forma)
        {
            return _db.FormaPagtoEditar(forma);
        }
        
    }
}
