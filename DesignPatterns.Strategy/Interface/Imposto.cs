using DesignPatterns.Strategy.Domain;

namespace DesignPatterns.Strategy.Interface
{
    public interface Imposto
    {
        double Calcular(Orcamento orcamento);
    }
}
