using DesignPatterns.Decorator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Interfaces
{
    public abstract class Imposto
    {
        private readonly Imposto outroImposto;

        public Imposto(Imposto outroImposto)
        {
            this.outroImposto = outroImposto;
        }

        // construtor default
        public Imposto()
        {
            this.outroImposto = null;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            if (outroImposto == null) return 0;
            return outroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
