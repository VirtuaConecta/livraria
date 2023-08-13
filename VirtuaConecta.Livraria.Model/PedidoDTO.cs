using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
   public class PedidoDTO
    {
        public Int32 Id { get; set; }
        public Int32 Id_ticket { get; set; }
        public Int32 Id_produto { get; set; }
        public Decimal Qtd { get; set; }
        public Decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public String DescGrid { get; set; }

        public Decimal ValorTotal { get; set; }

    }
}
	