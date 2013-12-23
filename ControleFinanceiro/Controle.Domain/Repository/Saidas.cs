
using System.Collections.Generic;
using Controle.Domain.Entities;

namespace Controle.Domain.Repository
{
    public class Saidas : BaseRepository
    {
        public Saida Obter(int codigo)
        {
            return Obter<Saida>(codigo);
        }

        public IList<Saida> Todos()
        {
            return Todos<Saida>();
        }
    }
}
