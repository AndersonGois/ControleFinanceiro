using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Controle.Domain.Mappings
{
   public sealed class SaidaMap :ClassMap<Saida>  
    {
       public SaidaMap()
       {
           Id(x => x.Codigo);
           Map(x => x.DataPagamento);
           Map(x => x.DataVencimento);
           Map(x => x.Nome);
           Map(x => x.Valor);
           References(x => x.Usuario);
       }
    }
}
