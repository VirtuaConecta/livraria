using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business
{
    public class UsuariosBusiness: BaseBis.IusuarioBll
    {
        Repository.BaseRepo.IdataConections _iusuario;
        public UsuariosBusiness()
        {
            _iusuario = Factory.CriaConexao();


        }

        public string AtualizaUsuarios(UsuariosDTO item)
        {
            return _iusuario.AtualizarUsuarios(item);
        }

        public string InsereUsuarios(UsuariosDTO item)
        {
            return _iusuario.InserirUsuarios(item);
        }

        public List<UsuariosDTO> ListaUsuarios()
        {
            return _iusuario.ListarUsuarios();
        }

        public List<UsuariosDTO> ListaUsuariosAtivos()
        {
            return _iusuario.ListarUsuarios().Where(x=>x.Bloqueado==0).ToList();
        }


        public String validaUsuario(UsuariosDTO user, String acao)
        {
            String resp = "OK";

            if (String.IsNullOrWhiteSpace(user.LoginUsuario) )
            {
                resp = "Inserir um login";
            }
            if (String.IsNullOrWhiteSpace(user.NomeUsuario))
            {
                resp = "Inserir um nome";
            }
            if (String.IsNullOrWhiteSpace(user.SenhaUsuario) && acao== "INSERIR")
            {
                resp = "Inserir uma Senha";
            }



            return resp;
        }
    }
}
