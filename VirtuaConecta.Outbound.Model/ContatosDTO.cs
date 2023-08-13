using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class ContatosDTO: BaseContatoDTO
    {

        public Int32 Id { get; set; }
        public DateTime? Data_contato { get; set; }
        public DateTime? Dia_ult_compra { get; set; }
        public String Bairro { get; set; }
        public Decimal valorMaiorCompra { get; set; }
        public String Endereco { get; set; }

        public String EnderecoEntrega { get; set; }
      
        public Int32 Dias_sem_compra { get; set; }

        public String Descricao_status { get; set; }
        public DateTime? Mes_Maior_compra { get; set; }

        
        public String Email { get; set; }
        public String Telefone { get; set; }
        public Int32 Status_contato { get; set; }
       

        public DateTime? Data_Agenda_contato { get; set; }

        public Int32? Cod_municipio { get; set; }
        public Int32 Em_atendimento { get; set; }
        public bool Chamar { get; set; }
      

        public String Nome_contato { get; set; }

        public int Seq { get; set; }


    }
}
