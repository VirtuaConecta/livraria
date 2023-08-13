using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class ListaConfigContatoDTO
    {

        public String Operador { get; set; }

        public String Carteiras { get; set; }
        public String  Prioridades { get; set; }

        public String Sequencia { get; set; }

        public bool Nao_cancelados { get; set; }

        public Int32 Dias_sem_Compras { get; set; }

    }
}
