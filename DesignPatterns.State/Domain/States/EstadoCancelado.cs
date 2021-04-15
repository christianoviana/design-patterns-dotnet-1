using DesignPatterns.State.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Domain.States
{
    public class EstadoCancelado: EstadoPagamento
    {
        public override void Aprovar()
        {
            throw new Exception("O pagamento foi cancelado e não pode ser aprovado.");
        }

        public override void Cancelar()
        {
            throw new Exception("O pagamento já foi cancelado.");
        }

        public override void EmAndamento()
        {
            throw new Exception("O pagamento já foi cancelado e não pode ir para 'Em Andamento'.");
        }

        public override void Finalizado()
        {
            Console.WriteLine("Finalizando Pagamento ###");
            this.Contexto.MudarDeEstado(new EstadoFinalizado());
            Console.WriteLine("Pagamento Finalizado ###");
        }
    }
}
