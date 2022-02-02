using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface ICarteiraServico<TEntity> : IBaseServico<Carteira>
    {
        TEntity BuscarPorCodigo(int idEmpresa, int id);

        TEntity AdicionarCarteira(TEntity carteira);

        TEntity AtualizarCarteira(TEntity carteira);

        List<TEntity> BuscarCarteiras(int codigoEmpresa);
    }
}