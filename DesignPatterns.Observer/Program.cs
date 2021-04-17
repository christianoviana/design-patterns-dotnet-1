using DesignPatterns.Observer.Models;
using System;

namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            MercadoDeAcoes<Acao> MercadoDeAcoes = new MercadoDeAcoes<Acao>();
            MercadoDeAcoes.Adicionar(new BradescoCorretora());
            MercadoDeAcoes.Adicionar(new ItauCorretora());

            var PETR3 = new Acao("PETR3", 27.55);
            var EMBR3 = new Acao("EMBR3", 14.70);

            MercadoDeAcoes.AdicionaAtualizaAcao(PETR3);
            MercadoDeAcoes.AdicionaAtualizaAcao(EMBR3);

            Console.ReadKey();

            var VVAR3 = new Acao("VVAR3", 12.15);
            MercadoDeAcoes.AdicionaAtualizaAcao(VVAR3);

            EMBR3.Preco = 14.82;
            MercadoDeAcoes.AdicionaAtualizaAcao(EMBR3);
            
            Console.ReadKey();
        }
    }
}
