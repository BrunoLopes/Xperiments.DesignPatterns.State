using System;
using Xperiments.DesignPatterns.State.Models;

namespace Xperiments.DesignPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItens(new Item("Caneta", 20));
            orcamento.AdicionaItens(new Item("Lápis", 15));
            orcamento.AdicionaItens(new Item("Borracha", 3));
            orcamento.AdicionaItens(new Item("Mochila", 300));

            Console.WriteLine(orcamento.Valor);

            orcamento.AplicaDescontoExtra();

            Console.WriteLine(orcamento.Valor);

            orcamento.Aprova();

            orcamento.AplicaDescontoExtra();

            Console.WriteLine(orcamento.Valor);

        }
    }
}
