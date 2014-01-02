using System.Collections.Generic;
using Controle.Domain.Entities;

namespace Controle.Domain.Repository
{
    public class Usuarios : BaseRepository
    {
        public Usuario Obter(int codigo)
        {
            return Obter<Usuario>(codigo);
        }
         public virtual IList<Usuario> Todos()
         {
             return Todos<Usuario>();
         }
        public virtual void  SalvarUsuario(Usuario usuario)
        {
            Salvar(usuario);
        }
    }
}
