namespace DesignPatterns.State.Domain.Interfaces
{
    public abstract class EstadoPagamento
    {
        protected ContextoDePagamento Contexto { get; private set; }

        public void SetContexto(ContextoDePagamento contexto)
        {
            this.Contexto = contexto;
        }

       public abstract void Aprovar();
       public abstract void EmAndamento();
       public abstract void Cancelar();
       public abstract void Finalizado();
    }
}
