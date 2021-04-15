using DesignPatterns.Builder.Domain.Models;
using System;

namespace DesignPatterns.Builder.Domain.Builders
{
    public class ConstruirNotaFiscal
    {
        private string RazaoSocial;
        private string CNPJ;
        private DateTime DataDeEmissao;
        private double ValorTotal;
        private double ValorImposto;
        private string Observacao;

        public ConstruirNotaFiscal()
        {
            this.DataDeEmissao = DateTime.Now;
        }

        public ConstruirNotaFiscal ComRazaoSocial(string nome)
        {
            this.RazaoSocial = nome;
            return this;
        }

        public ConstruirNotaFiscal ComCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }

        public ConstruirNotaFiscal ComDataDeEmissao(DateTime data)
        {
            this.DataDeEmissao = data;
            return this;
        }

        public ConstruirNotaFiscal ComValorTotal(double valor)
        {
            this.ValorTotal = valor;
            return this;
        }

        public ConstruirNotaFiscal ComValorImposto(double valor)
        {
            this.ValorImposto = valor;
            return this;
        }

        public ConstruirNotaFiscal ComObservacao(string observacao)
        {
            this.Observacao = observacao;
            return this;
        }

        public NotaFiscal Construir()
        {            
            return new NotaFiscal(this.RazaoSocial, this.CNPJ, this.DataDeEmissao, this.ValorTotal, this.ValorImposto, this.Observacao);
        }
    }
}
