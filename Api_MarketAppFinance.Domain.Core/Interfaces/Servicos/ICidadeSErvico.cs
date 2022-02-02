using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface ICidadeServico<TEntity> : IBaseServico<Cidade>
    {
        TEntity AdicionarCidade(TEntity dados);

        TEntity AtualizarCidade(TEntity dados);

        List<TEntity> BuscarTodos();

        TEntity BuscarPorCodigo(int codigo);
    }
}