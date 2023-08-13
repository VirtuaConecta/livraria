using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class HistoricoContatoDTO : BaseContatoDTO
    {
        public Int32 Mes_maior_comp { get; set; }
        public String Val_Maior_compra { get; set; }
        public String Dt_Ul_Compra { get; set; }
        public String Acao_contato { get; set; }
        public String Ocorrencia { get; set; }
        public String Dt_contato { get; set; }
        public String Operador { get; set; }



    }
}
