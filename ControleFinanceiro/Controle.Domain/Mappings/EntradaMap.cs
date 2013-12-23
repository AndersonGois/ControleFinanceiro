
using Controle.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Controle.Domain.Mappings
{
  public sealed class EntradaMap :ClassMap<Entrada>
    {
      public EntradaMap()
      {
          Id(x => x.Codigo);
          Map(x => x.Data);
          Map(x => x.DataPrevista);
          Map(x => x.Nome);
          Map(x => x.Valor);
          References(x => x.Usuario);
      }
    }
}
