using DesignPatterns.Strategy.Domain;
using DesignPatterns.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class ControladorDeImpostos
    {
        public double RealizaCalculo(Imposto imposto, Orcamento orcamento)
        {
            // DO ANYTHING
            return imposto.Calcular(orcamento);
        }
    }
}
