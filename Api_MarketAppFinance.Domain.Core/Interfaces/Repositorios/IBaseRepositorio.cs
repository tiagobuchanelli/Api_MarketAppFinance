namespace Api_MarketAppFinance.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepositorio<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);

        void Atualizar(TEntity obj);

        void Excluir(TEntity obj);
        
    }
}