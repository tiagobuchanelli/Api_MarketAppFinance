namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface IBaseServico<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);

        void Atualizar(TEntity obj);

        void Excluir(TEntity obj);

        IEnumerable<TEntity> BuscarTodos();

        TEntity BuscarPorCodigo(int id);
    }
}