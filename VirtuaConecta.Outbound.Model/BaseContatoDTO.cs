using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class BaseContatoDTO
    {
        public String Id_cliente { get; set; }
        public String Cnpj { get; set; }
        public String Cliente { get; set; }
        public String Canal_venda { get; set; }
        public String Situacao { get; set; }
        public String Cidade { get; set; }
        public String Cep { get; set; }
        public String Estado { get; set; }




    }
}
