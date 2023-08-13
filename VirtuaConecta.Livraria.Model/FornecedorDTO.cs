using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class FornecedorDTO
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public String Cpf_cnpj { get; set; }
        public String Fis_jur { get; set; }
        public String Ie  { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String Cidade { get; set; }
        public String  Estado { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Contato { get; set; }
        public Int32 Cod_mun { get; set; }
        public DateTime Data_cad { get; set; }
       

    }
}
