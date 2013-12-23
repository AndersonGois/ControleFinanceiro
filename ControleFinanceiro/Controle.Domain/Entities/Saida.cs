using System;
using Controle.Domain.Entities.Interfaces;

namespace Controle.Domain.Entities
{
    public class Saida : IAggregateRoot<int>
    {
        public virtual int Codigo { get; set; }
        public virtual DateTime DataVencimento { get; set; }
        public virtual DateTime DataPagamento { get; set; }
        public virtual long Valor { get; set; }
        public virtual string Nome { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
