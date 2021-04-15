using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Strategy.Domain
{
    public class ICMS : Imposto
    {
        private double percentual = 0.01;

        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * percentual;
        }
    }
}
