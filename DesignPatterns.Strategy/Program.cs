using DesignPatterns.Strategy.Domain;
using System;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ControladorDeImpostos controladorDeImpostos = new ControladorDeImpostos();
            Orcamento orcamento = new Orcamento(2000);

            var icms = controladorDeImpostos.RealizaCalculo(new ICMS(), orcamento);
            var iss  = controladorDeImpostos.RealizaCalculo(new ISS(), orcamento);
            var iccc  = controladorDeImpostos.RealizaCalculo(new ICCC(), orcamento);

            Console.WriteLine($"ICMS: {icms.ToString("C")}");
            Console.WriteLine($"ISS : {iss.ToString("C")}");
            Console.WriteLine($"ICCC : {iccc.ToString("C")}");

            Console.ReadKey();
        }
    }
}
