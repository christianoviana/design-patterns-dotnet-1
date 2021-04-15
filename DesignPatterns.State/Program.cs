using DesignPatterns.State.Domain.States;
using System;

namespace DesignPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextoDePagamento contexto = new ContextoDePagamento(new EstadoAndamento());
            contexto.Aprovar();
            contexto.Finalizar();

            Console.ReadKey();
        }
    }
}
