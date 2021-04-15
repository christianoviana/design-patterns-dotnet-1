using DesignPatterns.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Domain
{
    class ICCC : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            var imposto = 0.0;

            if (orcamento.Valor < 1000)
            {
                imposto = orcamento.Valor * 0.05;

            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                imposto = orcamento.Valor * 0.07;
            }
            else if (orcamento.Valor > 3000)
            {
                imposto = (orcamento.Valor * 0.08) + 30;
            }

            return imposto;
        }
    }
}
