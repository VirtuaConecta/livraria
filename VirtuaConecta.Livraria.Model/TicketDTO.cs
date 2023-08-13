using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class TicketDTO
    {
        public Int32 Id { get; set; }
        public Int32 Nr_ticket { get; set; }
        public Int32 Serie { get; set; }

        public Decimal Valor { get; set; }
        public DateTime Dt_ticket { get; set; }
        public String Cpf_cnpj { get; set; }
    }
}
