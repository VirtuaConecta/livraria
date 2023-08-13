using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class ObjetoCorreiosDTO
    {
        public String numero { get; set; }
        public String sigla { get; set; }
        public String nome { get; set; }
        public String categoria { get; set; }

        public EventosCorreiosDTO evento { get; set; }
    }
}
