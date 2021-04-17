using DesignPatterns.Observer.Interfaces;
using System;

namespace DesignPatterns.Observer.Models
{
    public class Acao: Entidade
    {
        public Acao(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Id = Guid.NewGuid();
        }
        
        public String Nome { get; private set; }
        public double Preco { get; set; }
    }
}
