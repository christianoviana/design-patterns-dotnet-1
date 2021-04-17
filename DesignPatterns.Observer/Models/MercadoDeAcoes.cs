using DesignPatterns.Observer.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace DesignPatterns.Observer.Models
{
    public class MercadoDeAcoes<T> : ISubject<T> where T :Entidade
    {
        private List<IObserver<T>> observadores = new List<IObserver<T>>();
        private List<T> acoes = new List<T>();

        public void AdicionaAtualizaAcao(T acao)
        {
            if (this.acoes.Any(x => x.Id == acao.Id))
            {
                var _acao = this.acoes.FirstOrDefault(a => a.Id == acao.Id);

                if (_acao != null)
                {
                    _acao = acao; 
                }
            }
            else
            {
                this.acoes.Add(acao);
            }

            this.Notificar();
        }
     
        public void Adicionar(IObserver<T> observador)
        {
            observadores.Add(observador);
        }

        public void Remover(IObserver<T> observador)
        {          
            observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var observador in observadores)
            {
                observador.Atualizar(acoes);
            }
        }      
    }
}
