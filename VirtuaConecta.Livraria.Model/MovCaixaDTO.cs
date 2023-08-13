using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class MovCaixaDTO
    {
        public Int32 Id { get; set; }
       
        public Int32 Id_caixa { get; set; }
        public Int32 Id_ticket { get; set; }
        public String Dt_operacao { get; set; }
        public Int32 Id_meio_pagto { get; set; }
        public String Meio_pagto { get; set; }
        public Decimal Valor { get; set; }
        public Decimal Desconto { get; set; }
        public Decimal Valor_final { get; set; }
        public Int32 Nr_ticket { get; set; }
        public Int32 SerieTicket { get; set; }
        public Int32 Id_operador { get; set; }
        public String Nome_operador { get; set; }
        public String Cpf_cnpj { get; set; }

    }
}
