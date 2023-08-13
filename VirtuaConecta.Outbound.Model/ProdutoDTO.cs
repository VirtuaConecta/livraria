using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class ProdutoDTO
    {
        public int id { get; set; }
        public String descricao { get; set; }
        public Decimal preco { get; set; }
        public String cod_barra { get; set; }
    }
}
