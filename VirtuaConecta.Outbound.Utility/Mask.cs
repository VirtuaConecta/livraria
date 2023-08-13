using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Utility
{
    public class Mask
    {
        public static string Telefone(String telefone)
        {
            String t= null;
            if (!String.IsNullOrEmpty(telefone))
            {
                var tel = TiraSeparacaoTelefone(telefone);

                if (tel.Length>=8)
                {
                    tel = "0000000000000" + tel;

                    t = tel.Substring(tel.Length - 12, 4) + " " + tel.Substring(tel.Length - 8,4) +"-"+ tel.Substring(tel.Length - 4);
                }

            }
           


            return t;
        }

        public static string TiraSeparacaoTelefone(String tel)
        {
            String tel1 = tel.Replace("-", "").Replace("(", "").Replace(")", "").Replace(".", "").Replace(" ", "");
            return tel1;
        }
    }
}
