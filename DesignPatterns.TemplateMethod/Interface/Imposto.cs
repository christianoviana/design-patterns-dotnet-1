using DesignPatterns.TemplateMethod.Domain;

namespace DesignPatterns.TemplateMethod.Interface
{
    public interface Imposto
    {
        double Calcular(Orcamento orcamento);
    }
}
