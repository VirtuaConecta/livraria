using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class ProdutoDTO
    {
        public String descricao { get; set; }
        public String cod_barra { get; set; }
        public int id { get; set; }
        public int id_familia { get; set; }
        public Decimal preco { get; set; }
        public String fornecedor { get; set; }
        public String obs { get; set; }
        public String local { get; set; }
        public String ncm { get; set; }
        public Decimal saldo { get; set; }
        public String Sku { get; set; }
    }
}
