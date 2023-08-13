using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Repository;
namespace VirtuaConecta.Outbound.Business
{
   public class ReceitaBLL : BaseBis.IreceitaWsBLL
    {
        private Repository.BaseRepo.IwsReceitaDAL _receita;
        public ReceitaBLL()
        {
            _receita = Factory.CriarReceitaDAL();
        }
        public RetornoReceitaWs BuscaInfoReceita(string CNPJ)
        {
            return _receita.BuscarInfoReceita(CNPJ);
        }
    }
}
