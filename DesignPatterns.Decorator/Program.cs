using DesignPatterns.Decorator.Domain;
using DesignPatterns.Decorator.Domain.Impostos;
using DesignPatterns.Decorator.Interfaces;
using System;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto impostoComplexo = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento();
            orcamento.Adicionar(new Item("Televisão 40", 1200));
            orcamento.Adicionar(new Item("Guarda-Roupa", 800));


            double valor = impostoComplexo.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
