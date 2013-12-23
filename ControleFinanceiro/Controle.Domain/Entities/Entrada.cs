using System;
using Controle.Domain.Entities.Interfaces;

namespace Controle.Domain.Entities
{
    public class Entrada : IAggregateRoot<int>
    {
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual DateTime DataPrevista { get; set; }
        public virtual long Valor { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
