
using System.Collections.Generic;
using Controle.Domain.Entities.Interfaces;

namespace Controle.Domain.Entities
{
    public class Usuario : IAggregateRoot<int>
    {
        public virtual int Codigo { get; set; }
        public virtual string Cpf { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Sobrenome { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual IList<Entrada> Entradas { get; set; }
        public virtual IList<Saida> Saidas { get; set; }

        public virtual void AdicionarSaida(Saida saida)
        {
            if (Saidas == null)
                Saidas = new List<Saida>();

            Saidas.Add(saida);
        }

        public virtual void AdicionarEntrada(Entrada entrada)
        {
            if (Entradas == null)
                Entradas = new List<Entrada>();

            Entradas.Add(entrada);
        }

        public virtual void RemoveEntrada(Entrada entrada)
        {
            if (Entradas == null)
                Entradas = new List<Entrada>();

            Entradas.Remove(entrada);
        }

        public virtual void RemoveSaida(Saida saida)
        {
            if (Saidas == null)
                Saidas = new List<Saida>();

            Saidas.Remove(saida);
        }

       
    }
}
