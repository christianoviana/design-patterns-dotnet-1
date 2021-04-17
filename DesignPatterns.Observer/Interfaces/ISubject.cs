namespace DesignPatterns.Observer.Interfaces
{
    public interface ISubject<T> where T:Entidade
    {
        void Adicionar(IObserver<T> observador);
        void Remover(IObserver<T> observador);
        void Notificar();
    }
}
