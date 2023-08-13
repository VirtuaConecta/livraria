using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Business
{
    public class ReportsBLL : BaseBis.IreportsBll
    {
        private Repository.BaseRepo.IdataConections _report;
        public ReportsBLL()
        {
            _report = Factory.CriaConexao();
        }


        public List<DashDTO> Db_venda_produtoBll(String dt_in, String dt_fim, String ordem)
        {

            return _report.Db_venda_produto(dt_in,dt_fim,  ordem);

        }

        public List<DashDTO> Db_venda_familiaBll(String dt_in, String dt_fim)
        {

            return _report.Db_venda_familiaValor(dt_in, dt_fim);

        }

        public List<DashDTO> Db_venda_meioValorBll(String dt_in, String dt_fim)
        {

            return _report.Db_venda_MeioValor(dt_in, dt_fim);

        }
    }
}
