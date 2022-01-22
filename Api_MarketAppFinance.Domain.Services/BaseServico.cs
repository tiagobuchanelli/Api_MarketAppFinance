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

        public void Adicionar(TEntity obj)
        {
            _repository.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public void Excluir(TEntity obj)
        {
            _repository.Excluir(obj);
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            return _repository.BuscarTodos();
        }

        public TEntity BuscarPorCodigo(int id)
        {
            return _repository.BuscarPorCodigo(id);
        }
    }
}