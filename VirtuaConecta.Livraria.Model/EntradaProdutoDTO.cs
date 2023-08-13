using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class EntradaProdutoDTO
    {
       public  HeadEntradaProd Head { get; set; }

       public  List<ItemEntradaProd> Itens  { get; set; }
    }

    public class HeadEntradaProd
    {
        public Int32 Id { get; set; }
        public String Nr_doc { get; set; }
        public String Nf_nfe { get; set; }
        public String Serie { get; set; }
        public DateTime Data_emissao { get; set; }
        public DateTime Data_entrada { get; set; }
        public String Chave { get; set; }
        public Int32 Id_fornecedor { get; set; }
    }
    public class ItemEntradaProd
    {

        public Int32 Id { get; set; }
        public String  Nr_doc { get; set; }
        public Int32 Id_produto { get; set; }
        public Decimal Qtd { get; set; }

        public String DescSku { get; set; }
    }
}
