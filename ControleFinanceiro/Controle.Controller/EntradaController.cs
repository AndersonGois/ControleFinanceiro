
using System.Collections.Generic;
using Controle.Domain.Entities;
using Controle.Domain.Repository;

namespace Controle.Controller
{
    public class EntradaController
    {

        public void SalvarEntrada(Entrada entrada)
        {
            (new Entradas()).SalvarEntrada(entrada);

        }

        public Entrada ObterEntrada(int codigo)
        {
            var entradas = new Entradas();
            return entradas.Obter(codigo);
        }

        public IList<Entrada> Todos()
        {
            var entradas = new Entradas();
            return entradas.Todos();
        }

    }
}
