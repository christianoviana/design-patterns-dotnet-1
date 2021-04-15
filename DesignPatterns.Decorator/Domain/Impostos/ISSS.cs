using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Domain.Impostos
{
    public class ISS : Imposto
    {
        public ISS()
        {
        }

        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Total * 0.06 + this.CalculoDoOutroImposto(orcamento);
        }      
    }
}
