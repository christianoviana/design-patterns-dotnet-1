using System.Collections.Generic;

namespace DesignPatterns.Observer.Interfaces
{
    public interface IObserver<T> where T : Entidade
    {
        void Atualizar(IEnumerable<T> informacao);
    }
}
