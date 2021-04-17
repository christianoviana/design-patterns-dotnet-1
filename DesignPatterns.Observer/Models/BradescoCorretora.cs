using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.Models
{
    class BradescoCorretora : DesignPatterns.Observer.Interfaces.IObserver<Acao>
    {
        public void Atualizar(IEnumerable<Acao> informacao)
        {
            Console.WriteLine("====== Bradesco Corretora ======");

            foreach (var info in informacao)
            {
                Console.WriteLine($"Id: {info.Id} - Nome: {info.Nome} - Preço: {info.Preco}");
            }
        }
    }
}
