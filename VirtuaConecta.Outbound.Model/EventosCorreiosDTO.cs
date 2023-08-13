using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class EventosCorreiosDTO : TipoEventoCorreioDTO
    {

        public Int32 id { get; set; }

        public Int32 Status { get; set; }
        public String descricao { get; set; }
        public String detalhe { get; set; }

        public String local { get; set; }
        public String codigo { get; set; }
        public String cidade { get; set; }
        public String uf { get; set; }

        public string data { get; set; }
        public String hora { get; set; }

    }
}
