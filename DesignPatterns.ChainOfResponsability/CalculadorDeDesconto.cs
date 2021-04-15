using DesignPatterns.ChainOfResponsability.Domain;
using DesignPatterns.ChainOfResponsability.Domain.Descontos;

namespace DesignPatterns.ChainOfResponsability
{
    public class CalculadorDeDesconto
    {
        public double ConcederDesconto(Orcamento orcamento)
        {
            DescontoPorMaisDeQuinhentosReais d2 = new DescontoPorMaisDeQuinhentosReais();
            DescontoPorCincoItens d1 = new DescontoPorCincoItens(d2);
         
            return d1.CalcularDesconto(orcamento);
        }
    }
}
