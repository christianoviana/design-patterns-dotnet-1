using System;

namespace DesignPatterns.Builder.Domain.Models
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorTotal { get; private set; }
        public double Imposto { get; private set; }
        public string Observacao { get; private set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, double valorTotal, double imposto, string observacao)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorTotal = valorTotal;
            Imposto = imposto;
            Observacao = observacao;
        }      
    }
}
