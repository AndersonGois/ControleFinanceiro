using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle.Controller;
using Controle.Domain.Entities;
using System.ComponentModel;
namespace Controle.View
{
    public class EntradaView
    {
        public DateTime Data { get; set; }

        [DisplayName("Data Prevista")]
        public DateTime DataPrevista { get; set; }

        [Display(Name = "Nome")]
        //[Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public long Valor { get; set; }
        public int Codigo { get; set; }
        public UsuarioView Usuario { get; set; }

        public void InserirEntrada(EntradaView view)
        {
            var entrada = new Entrada
                              {
                                  Codigo = view.Codigo,
                                  Data = view.Data,
                                  DataPrevista = view.DataPrevista,
                                  Nome = view.Nome,
                                  Valor = view.Valor,
                                  Usuario = new Usuario { Codigo = view.Usuario.Codigo, Cpf = view.Usuario.Cpf, Login = view.Usuario.Login, Nome = view.Usuario.Nome, Senha = view.Usuario.Senha, Sobrenome = view.Usuario.Sobrenome }
                              };
            var entradaController = new EntradaController();

            entradaController.SalvarEntrada(entrada);

        }



    }

}
