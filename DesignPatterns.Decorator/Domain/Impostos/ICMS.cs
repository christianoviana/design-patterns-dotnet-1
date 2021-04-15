using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Domain.Impostos
{
    public class ICMS : Imposto
    {
        public ICMS()
        {
        }

        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Total * 0.04 + this.CalculoDoOutroImposto(orcamento);
        }      
    }
}
