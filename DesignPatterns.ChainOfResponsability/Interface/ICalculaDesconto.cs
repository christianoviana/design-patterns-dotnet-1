using DesignPatterns.ChainOfResponsability.Domain;

namespace DesignPatterns.ChainOfResponsability.Interface
{
    public abstract class Desconto
    {
        public Desconto()
        {
            this.Proximo = null;
        }

        public Desconto(Desconto proximo)
        {
            this.Proximo = proximo;
        }

        protected double ProximoDesconto(Orcamento orcamento)
        {
            if (Proximo == null)
                return 0;

            return Proximo.CalcularDesconto(orcamento);
        }

        protected Desconto Proximo { get; set; }
        public abstract double CalcularDesconto(Orcamento orcamento);
    }
}
