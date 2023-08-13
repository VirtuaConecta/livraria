using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Outbound.Model
{
    public class UsuariosDTO
    {
        public int Id { get; set; }
        public String NomeUsuario { get; set; }
        public String LoginUsuario { get; set; }
        public int IdPerfil { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String SenhaUsuario { get; set; }
        public String Obs { get; set; }
        public int Bloqueado { get; set; }
    }
}
