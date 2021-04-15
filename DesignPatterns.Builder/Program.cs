using DesignPatterns.Builder.Domain.Builders;
using System;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstruirNotaFiscal construtor = new ConstruirNotaFiscal();
            construtor.ComRazaoSocial("Casa do Código")
                      .ComCNPJ("12345678909")
                      .ComDataDeEmissao(DateTime.Now)
                      .ComValorTotal(150.00)
                      .ComValorImposto(150.00 * 0.02)
                      .ComObservacao("Nota Fiscal");

            var notaFiscal = construtor.Construir();
            Console.ReadKey();
                      
        }
    }
}
