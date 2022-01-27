using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface ICidadeSErvico<TEntity> : IBaseServico<Cidade>
    {
        TEntity AdicionarCidade(TEntity dados);

        TEntity AtualizarCidade(TEntity dados);
    }
}