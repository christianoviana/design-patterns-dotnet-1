using DesignPatterns.ChainOfResponsability.Interface;

namespace DesignPatterns.ChainOfResponsability.Domain.Descontos
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {

        public DescontoPorMaisDeQuinhentosReais() : base()
        {
        }

        public DescontoPorMaisDeQuinhentosReais(Desconto proximo) : base(proximo)
        {
        }

        public override double CalcularDesconto(Orcamento orcamento)
        {
            if (orcamento.Total > 500)
            {
                return orcamento.Total * 0.07;
            }
                       
            return this.ProximoDesconto(orcamento);
        }
    }
}
