using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Interrfaces.Repositories
{
    public interface ICarteiraRepositorio<TEntity> : IBaseRepositorio<Carteira>
    {
        List<TEntity> BuscarCarteiras(int idEmpresa);
    }
}