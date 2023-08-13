using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class MovEstoqueDTO
    {
        public String Nr_documento { get; set; }
        public String Tipo { get; set; }
        public String Serie { get; set; }
        public DateTime Dt_emissao { get; set; }
        public String Sku { get; set; }
        public String Descricao { get; set; }
        public Decimal Qtd_in { get; set; }
        public Decimal Qtd_out { get; set; }


    }
}
