using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Controle.Domain.Mappings
{
   public sealed class UsuarioMap :ClassMap<Usuario>
    {
       public UsuarioMap()
       {
           Id(x => x.Codigo);
           Map(x => x.Cpf);
           Map(x => x.Nome);
           Map(x => x.Sobrenome);
           HasMany(x => x.Saidas).Cascade.All();
           HasMany(x => x.Entradas).Cascade.All();

           
       }
    }
}
