using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface ICarteiraServico<TEntity> : IBaseServico<Carteira>
    {
        TEntity AdicionarCarteira(TEntity dados);

        TEntity AtualizarCarteira(TEntity dados);

        List<TEntity> BuscarCarteiras(int codigoEmpresa);
    }
}