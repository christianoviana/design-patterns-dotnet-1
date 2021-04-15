using DesignPatterns.TemplateMethod.Domain;
using DesignPatterns.TemplateMethod.Interface;
using System.Linq;

namespace DesignPatterns.TemplateMethod.Domain
{
    public class IKCV : TemplateDeImpostoCondicional
    {               
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Total * 0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Total * 0.06;
        }

        protected override bool UsaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Total > 500 && TemItemMaiorQue100(orcamento);             
        }

        private bool TemItemMaiorQue100(Orcamento orcamento)
        {
            return orcamento.Itens.Any(i => i.Valor > 100);
        }    
    }
}
