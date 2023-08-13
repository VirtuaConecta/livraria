using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class EndCepDTO
    {
        //classe para web service correio
        public String Endereco { get; set; }
        public String Complemento { get; set; }

        public String Complemento2 { get; set; }
        public String Bairro { get; set; }

        public String Cidade { get; set; }

        public String Uf { get; set; }

        public object Und_post { get; set; }


    }

    public class EnderecoCepDTO
    {
        public String cep { get; set; }
        public String logradouro { get; set; }
        public String complemento { get; set; }
        public String bairro { get; set; }

        public String localidade { get; set; }
        public String uf { get; set; }
        public String ibge { get; set; }
        public String gia { get; set; }


    }

}
