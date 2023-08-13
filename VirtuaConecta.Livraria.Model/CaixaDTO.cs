using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class CaixaDTO
    {
        public Int32 Id { get; set; }
        public String Terminal { get; set; }
        public Int32 Nr_caixa { get; set; }
        public Int32 Id_usr { get; set; }
        public String Nome_Usr { get; set; }
        public String Cargo_Usr { get; set; }
        public String Dt_Hr_operacao { get; set; }
        public Int32 Cod_Operacao { get; set; }
        public String Nome_operacao { get; set; }
        public Decimal Valor { get; set; }
        public Decimal Saldo { get; set; }
        public String Obs { get; set; }
        public String Cnpj_loja { get; set; }
    }
}
