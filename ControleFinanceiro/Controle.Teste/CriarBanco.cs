
using Controle.Domain.Entities;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace Controle.Teste
{
    [TestFixture]
    public class CriarBanco
    {
        [Test]
        //[Ignore]
        public void a__Criar_Banco_De_Dados_Por_Modelo()
        {
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2005.ConnectionString(c => c
           .FromAppSetting("Conexao")
            )).Mappings(m => m.FluentMappings.AddFromAssemblyOf<Entrada>()).Mappings(m => m.MergeMappings())
            .ExposeConfiguration(BuildSchema).BuildSessionFactory();
        }

        private void BuildSchema(Configuration config)
        {
            new SchemaExport(config)
                .Drop(true, true);

            new SchemaExport(config)
                .Create(true, true);
        }
    }
}
