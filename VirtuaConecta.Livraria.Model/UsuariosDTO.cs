using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class UsuariosDTO
    {


        public Int32 Id { get; set; }
        public String NomeUsuario { get; set; }
        public String LoginUsuario { get; set; }
        public Int32 IdPerfil { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String SenhaUsuario { get; set; }
        public String Obs { get; set; }
        public Int32 Bloqueado { get; set; }


    }
}
