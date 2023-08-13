using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class RetornoReceitaWs
    {
        public String nome { get; set; }
        public String situacao { get; set; }

        public String bairro { get; set; }
        public String logradouro { get; set; }
        public String numero { get; set; }
        public String cep { get; set; }
        public String uf { get; set; }
        public String municipio { get; set; }

        public String complemento { get; set; }

    }
}
