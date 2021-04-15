using DesignPatterns.State.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Domain.States
{
    public class EstadoAndamento : EstadoPagamento
    {
        public override void Aprovar()
        {
            Console.WriteLine("Aprovando Pedido ###");
            this.Contexto.MudarDeEstado(new EstadoAprovado());
            Console.WriteLine("Pedido Aprovado ###");
        }

        public override void Cancelar()
        {
            Console.WriteLine("Cancelando pagamento ###");
            this.Contexto.MudarDeEstado(new EstadoCancelado());
            Console.WriteLine("Pagamento cancelado ###");
        }

        public override void EmAndamento()
        {
            throw new Exception("O pagamento já está no status 'Em Andamento'.");
        }

        public override void Finalizado()
        {
            throw new Exception("O pagamento não pode ser finalizado.");
        }
    }
}
