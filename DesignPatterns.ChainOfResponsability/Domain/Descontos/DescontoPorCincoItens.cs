using DesignPatterns.ChainOfResponsability.Interface;

namespace DesignPatterns.ChainOfResponsability.Domain.Descontos
{
    public class DescontoPorCincoItens : Desconto
    {
        public DescontoPorCincoItens():base()
        {
        }

        public DescontoPorCincoItens(Desconto proximo):base(proximo)
        {
        }
           
        public override double CalcularDesconto(Orcamento orcamento)
        {
            if (orcamento.Itens != null && orcamento.Itens.Count >= 5)
            {
                return orcamento.Total * 0.1;
            }

            return this.ProximoDesconto(orcamento);          
        }
    }
}
