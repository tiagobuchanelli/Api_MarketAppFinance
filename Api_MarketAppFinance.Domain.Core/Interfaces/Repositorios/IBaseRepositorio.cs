namespace Api_MarketAppFinance.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepositorio<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}