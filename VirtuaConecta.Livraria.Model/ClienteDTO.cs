using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class ClienteDTO
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public String Cpf_cnpj { get; set; }

        public String  Fis_jur { get; set; }
        public String Ie { get; set; }
        public String End { get; set; }
        public String Num { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public Decimal Contri { get; set; }
        public String Data { get; set; }
        public String  Data_cad { get; set; }
        public String Cep { get; set; }
        public String Uf { get; set; }
    }
}

