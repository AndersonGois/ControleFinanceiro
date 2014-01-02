using System.Collections.Generic;
using System.Linq;
using Controle.Controller;
using Controle.Domain.Entities;

namespace Controle.View
{
    public class UsuarioView
    {
        public int Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public IList<EntradaView> Entradas { get; set; }
        public IList<SaidaView> Saidas { get; set; }

        public void AdicionarSaida(SaidaView saida)
        {
            if (Saidas == null)
                Saidas = new List<SaidaView>();

            Saidas.Add(saida);
        }

        public void AdicionarEntrada(EntradaView entrada)
        {
            if (Entradas == null)
                Entradas = new List<EntradaView>();

            Entradas.Add(entrada);
        }

        public void RemoveEntrada(EntradaView entrada)
        {
            if (Entradas == null)
                Entradas = new List<EntradaView>();

            Entradas.Remove(entrada);
        }

        public void RemoveSaida(SaidaView saida)
        {
            if (Saidas == null)
                Saidas = new List<SaidaView>();

            Saidas.Remove(saida);
        }


        public void InserirUsuario(UsuarioView view)
        {
            var usuario = new Usuario
                              {
                                  Codigo = view.Codigo,
                                  Login = view.Login,
                                  Senha = view.Senha,
                                  Nome = view.Nome,
                                  Cpf = view.Cpf,
                                  Sobrenome = view.Sobrenome
                              };
            var usuarioController = new UsuarioController();

            usuarioController.SalvarUsuario(usuario);

        }

        public UsuarioView ObterUsuarioPorLoginSenha(UsuarioView usuarioView)
        {
            var usuarioController = new UsuarioController();
            var usu = usuarioController.ObterUsuarioLoginSenha(usuarioView.Login, usuarioView.Senha);
            var usuario = new UsuarioView
                       {
                           Codigo = usu.Codigo,
                           Cpf = usu.Cpf,
                           Login = usu.Login,
                           Senha = usu.Senha,
                           Nome = string.Concat(usu.Nome," consegui"),
                           Sobrenome = usu.Sobrenome

                       };
            foreach (var eView in usu.Entradas.Select(item => new EntradaView
                                                                  {
                                                                      Codigo = item.Codigo,
                                                                      Data = item.Data,
                                                                      DataPrevista = item.DataPrevista,
                                                                      Nome = item.Nome,
                                                                      Valor = item.Valor
                                                                  }))
            {
                usuario.AdicionarEntrada(eView);
            }

           

            return usuario;
        }



    }

}
