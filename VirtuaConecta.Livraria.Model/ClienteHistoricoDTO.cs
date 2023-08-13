using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class ClienteHistoricoDTO
    {
        public int id { get; set; }
        public string data { get; set; }
        public decimal valor { get; set; }
        public int id_cliente { get; set; }
        public string refrencia { get; set; }
    }
}
