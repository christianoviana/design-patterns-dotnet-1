using DesignPatterns.State.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class ContextoDePagamento
    {
        private EstadoPagamento EstadoPagamento = null;

        public ContextoDePagamento(EstadoPagamento estado)
        {
            this.MudarDeEstado(estado);
        }

        public void MudarDeEstado(EstadoPagamento estado)
        {
            Console.WriteLine($"Mudando Para o Estado: {estado.GetType().Name}");
            this.EstadoPagamento = estado;
            this.EstadoPagamento.SetContexto(this);
        }

        public void Aprovar()
        {
            this.EstadoPagamento.Aprovar();
        }

        public void EmAndamento()
        {
            this.EstadoPagamento.EmAndamento();
        }

        public void Cancelar()
        {
            this.EstadoPagamento.Cancelar();
        }

        public void Finalizar()
        {
            this.EstadoPagamento.Finalizado();
        }
    }
}
