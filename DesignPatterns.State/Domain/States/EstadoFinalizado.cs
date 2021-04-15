using DesignPatterns.State.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Domain.States
{
    public class EstadoFinalizado : EstadoPagamento
    {
        public override void Aprovar()
        {
            throw new Exception("O pagamento já foi finalizado.");
        }

        public override void Cancelar()
        {
            throw new Exception("O pagamento já foi finalizado.");
        }

        public override void EmAndamento()
        {
            throw new Exception("O pagamento já foi finalizado.");
        }

        public override void Finalizado()
        {
            throw new Exception("O pagamento já foi finalizado.");
        }
    }
}
