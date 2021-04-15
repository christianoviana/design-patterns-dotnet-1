using DesignPatterns.ChainOfResponsability.Domain;
using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDesconto calculadorDeDesconto = new CalculadorDeDesconto();
            Orcamento orcamento = new Orcamento();

            orcamento.Adicionar(new Item("Cama Ortobom", 900));
            orcamento.Adicionar(new Item("Travesseiro", 50));

            var desconto = calculadorDeDesconto.ConcederDesconto(orcamento);

            Console.WriteLine($"Valor Do Orçamento: R$ {orcamento.Total}");
            Console.WriteLine($"Valor Com Desconto: R$ {orcamento.Total - desconto}");
            Console.WriteLine($"Valor Do Desconto: R$ {desconto}");
            Console.ReadKey();
        }
    }
}
