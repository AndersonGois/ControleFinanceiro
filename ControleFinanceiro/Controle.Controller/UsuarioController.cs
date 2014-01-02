
using System.Collections.Generic;
using Controle.Domain.Entities;
using Controle.Domain.Repository;
using System.Linq;

namespace Controle.Controller
{
    public class UsuarioController
    {

        public void SalvarUsuario(Usuario usuario)
        {
            (new Usuarios()).SalvarUsuario(usuario);

        }

        public Usuario ObterUsuario(int codigo)
        {
            var usuarios = new Usuarios();
            return usuarios.Obter(codigo);
        }

        public IList<Usuario> Todos()
        {
            var usuarios = new Usuarios();
            return usuarios.Todos();
        }

        public Usuario ObterUsuarioLoginSenha(string login , string senha)
        {
            var usuarios = new Usuarios();

            var teste = usuarios.Todos().FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper() && x.Senha == senha);
            return teste;
        }

    }
}
