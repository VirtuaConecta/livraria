using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
   public class FiltrosDTO
    {
        public int Id { get; set; }
        public String Cod_Filtro { get; set; }
        public String Descricao { get; set; }
        public String Sql { get; set; }
    }
}
