using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Interrfaces.Repositories
{
    public interface ICarteiraRepositorio<TEntity> : IBaseRepositorio<Carteira>
    {
        TEntity BuscarPorCodigo(int idEmpresa, int codigo);

        List<TEntity> BuscarTodos(int idEmpresa);

        List<TEntity> BuscarCarteiras(int idEmpresa);
    }
}