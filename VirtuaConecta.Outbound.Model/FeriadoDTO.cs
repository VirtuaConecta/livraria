using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Model
{
    public class FeriadoDTO
    {
        public String date { get; set; }
        public String name { get; set; }
        public String link { get; set; }
        public String type { get; set; }
        public String description { get; set; }

        public String type_code { get; set; }


    }
}
