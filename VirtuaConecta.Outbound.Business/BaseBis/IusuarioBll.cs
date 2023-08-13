using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
   public  interface IusuarioBll
    {

        List<UsuariosDTO> ListaUsuarios();
        List<UsuariosDTO> ListaUsuariosAtivos();
        String InsereUsuarios(UsuariosDTO item);
        String AtualizaUsuarios(UsuariosDTO item);
        String validaUsuario(UsuariosDTO user,String Acao);
    }
}
