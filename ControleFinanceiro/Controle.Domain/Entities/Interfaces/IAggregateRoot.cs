using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Domain.Entities.Interfaces
{
    public interface IAggregateRoot<T>
    {
        T Codigo { get; }
    }
}
