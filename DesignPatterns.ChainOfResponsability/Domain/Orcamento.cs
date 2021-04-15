using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.ChainOfResponsability.Domain
{
    public class Orcamento
    {
        public Orcamento()
        {
            this.Itens = new List<Item>();
        }

        public void Adicionar(Item item)
        {
            this.Itens.Add(item);
        }

        public void Remover(Item item)
        {
            this.Itens.Remove(item);
        }

        public double Total
        {
            get {
                return this.Itens.Sum(i => i.Valor);
            }
            private set { }
        }

        public List<Item> Itens { get; private set; }
    }
}
