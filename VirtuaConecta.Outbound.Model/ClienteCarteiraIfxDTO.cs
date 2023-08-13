using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class ClienteCarteiraIfxDTO
    {

        public String Cliente_fornecedor { get; set; }
        public String Cod_tipo_carteira { get; set; }

        public String Desc_tipo_carteira { get; set; }

        public String Cod_representante { get; set; }

        public String Desc_canal_venda { get; set; }
    }
}
