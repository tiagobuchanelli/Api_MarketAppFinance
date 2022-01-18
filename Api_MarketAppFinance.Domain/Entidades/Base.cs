namespace Api_MarketAppFinance.Domain.Entities
{
    public abstract class Base
    {
        public virtual int Id { get; protected set; }

        public virtual DateTime DataAtualizacao { get; protected set; }

        public virtual DateTime DataCriacao { get; protected set; }
    }
}