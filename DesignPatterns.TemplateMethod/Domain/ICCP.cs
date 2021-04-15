using DesignPatterns.TemplateMethod.Interface;

namespace DesignPatterns.TemplateMethod.Domain
{
    class ICCP : TemplateDeImpostoCondicional
    {     
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Total * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Total * 0.05;
        }

        protected override bool UsaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Total >= 500;
        }
    }
}
