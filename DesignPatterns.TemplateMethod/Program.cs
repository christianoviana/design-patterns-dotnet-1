using DesignPatterns.TemplateMethod.Domain;
using System;

namespace DesignPatterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateDeImpostoCondicional imposto = new IKCV();
         
            Orcamento orcamento = new Orcamento();

            orcamento.Adicionar(new Item("Cama Ortobom", 900));
            orcamento.Adicionar(new Item("Travesseiro", 50));

            var valorImposto = imposto.Calcular(orcamento);

            Console.WriteLine($"Valor Do Imposto: R$ {valorImposto}");
            Console.ReadKey();
        }
    }
}
