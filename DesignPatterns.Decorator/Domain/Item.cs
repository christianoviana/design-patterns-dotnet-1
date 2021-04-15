namespace DesignPatterns.Decorator.Domain
{
    public class Item
    {
        public Item(string name, double valor)
        {
            Name = name;
            Valor = valor;
        }

        public string Name { get; private set; }
        public double Valor { get; private set; }
    }
}
