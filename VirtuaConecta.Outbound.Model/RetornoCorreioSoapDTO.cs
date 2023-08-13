using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class RetornoCorreioSoapDTO
    {


        public String versao { get; set; }
        public String qtd { get; set; }
        public ObjetoCorreiosDTO objeto { get; set; }

    }
}
