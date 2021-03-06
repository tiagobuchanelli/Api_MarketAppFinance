using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;

namespace Api_MarketAppFinance.Domain.Services
{
    public class ServicoBase<TEntity> : IBaseServico<TEntity> where TEntity : class
    {
        private readonly IBaseRepositorio<TEntity> _repository;

        public ServicoBase(IBaseRepositorio<TEntity> repository)
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
       
    }
}