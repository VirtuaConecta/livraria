using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class ClienteLogixDTO
    {
        public String Id_cliente { get; set; }
        public String Cliente { get; set; }
        public String Cidade { get; set; }
        public String Bairro { get; set; }

        public String Endereco { get; set; }

        public String Estado { get; set; }

        public String Cep { get; set; }
        public String Cnpj { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public Int32? Cod_municipio { get; set; }
        public String Situacao { get; set; }


    }
}
