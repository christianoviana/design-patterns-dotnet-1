using DesignPatterns.TemplateMethod.Domain;
using DesignPatterns.TemplateMethod.Interface;

namespace DesignPatterns.TemplateMethod
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (UsaMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        protected abstract bool UsaMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
