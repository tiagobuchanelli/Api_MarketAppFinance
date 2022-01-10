using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;

namespace Api_MarketAppFinance.Domain.Services
{
    public class BaseServico<TEntity> : IBaseServico<TEntity> where TEntity : class
    {
        private readonly IBaseRepositorio<TEntity> _repository;

        public BaseServico(IBaseRepositorio<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}