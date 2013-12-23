
using System;
using Controle.Domain.Entities;
using Controle.Domain.Repository;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using System.Linq;

namespace Controle.Teste
{
    [TestFixture]
    public class TesteControle
    {
        private Usuarios _usuarios;
        private Entradas _entradas;
        private Saidas _saidas;


        [Test]
        public void a_nicializar()
        {

            _saidas = new Saidas();
            _entradas = new Entradas();
            _usuarios = new Usuarios();

        }


        [Test]
        //[Ignore]
        public void InserirUsuario()
        {

            _usuarios = new Usuarios();
            var usuario = new Usuario
                              {
                                  Nome = "Anderson",
                                  Cpf = "4849489489",
                                  Sobrenome = "Ribeiro"
                              };
            var entrada = new Entrada
                              {
                                  Data = new DateTime(2013, 12, 17),
                                  Nome = "Triscal",
                                  DataPrevista = new DateTime(2013, 12, 18),
                                  Valor = 22500
                              };
            var saida = new Saida
                            {
                                DataPagamento = new DateTime(2013, 12, 17),
                                Nome = "Visa",
                                Valor = 500,
                                DataVencimento = new DateTime(2013, 12, 17)
                            };
            usuario.AdicionarEntrada(entrada);
            usuario.AdicionarSaida(saida);
            _usuarios.Salvar(usuario);

        }

        [Test]
        [Ignore]
        public void b_InserirSaida()
        {


         
            var saida = new Entrada()
                            {
                                Data = DateTime.Now,
                                DataPrevista = DateTime.Now,
                                Nome = "VISA",
                                Valor = 500
                            };
            (new Entradas()).SalvarEntrada(saida);
        }



        [Test]
        //[Ignore]
        public void d_Verificar_Saldo_de_Usuario()
        {
            _usuarios = new Usuarios();

            var usue = _usuarios.Todos().FirstOrDefault(x => x.Nome == "Rejane");
            if (usue == null) return;
            var udu = _usuarios.Obter(usue.Codigo);

            var usu = _usuarios.Obter(udu.Codigo);
            var saldo = usu.Entradas.Sum(x => x.Valor) - usu.Saidas.Sum(x => x.Valor);

            Assert.IsTrue(saldo > 0, "Saldo Negativo");

        }


        //[Test]
        //[Ignore]
        //public void c_Inserir_Usuario()
        //{
        //    var entrada1 = _entradas.Obter(1);
        //    //var saida1 = _saidas.Obter(2);
        //    //var saida2 = _saidas.Obter(3);

        //    var usuario = _usuarios.Obter(1);
        //    //usuario.AdicionarSaida(saida1);
        //    //usuario.AdicionarSaida(saida2);
        //    usuario.AdicionarEntrada(entrada1);

        //    _usuarios.Salvar(usuario);

        //}



        [Test]
        //    [Ignore]
        public void e_Deletar_usuario()
        {
            _usuarios = new Usuarios();
            foreach (var item in _usuarios.Todos().Where(x => x.Nome == "Rejane"))
            {
                var udu = _usuarios.Obter(item.Codigo);

                _usuarios.Deletar(udu);
            }
        }

    }
}
