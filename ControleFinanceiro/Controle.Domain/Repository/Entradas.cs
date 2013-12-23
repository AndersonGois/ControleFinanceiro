
using System.Collections.Generic;
using Controle.Domain.Entities;

namespace Controle.Domain.Repository
{
    public class Entradas : BaseRepository
    {
        public Entrada Obter(int codigo)
        {
            return Obter<Entrada>(codigo);
        
        }

        public  void SalvarEntrada(Entrada entrada)
        {
            Salvar(entrada);
        }

        public IList<Entrada> Todos()
        {
            return Todos<Entrada>();
        }
    }
}
