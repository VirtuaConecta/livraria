using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class HistoricoDTO
    {
        public String Id { get; set; }
        public String Historico_Desc { get; set; }
        public DateTime Dt_retorno { get; set; }
        public int Status_contato { get; set; }
        public DateTime Dt_contato { get; set; }
        public int Id_contato { get; set; }
        public String Operador { get; set; }

        public String Desc_status { get; set; }

        public int Nr_contatos { get; set; }

        public int ativo { get; set; }
    }
}
