using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Strategy.Domain
{
    public class ISS : Imposto
    {
        private double percentual = 0.06;

        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * percentual;
        }
    }
}
