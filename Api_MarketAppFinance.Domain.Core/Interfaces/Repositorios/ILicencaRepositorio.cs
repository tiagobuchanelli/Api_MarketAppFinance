using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Interrfaces.Repositories
{
    public interface ILicencaRepositorio<TEntity> : IBaseRepositorio<Licenca>
    {
        List<TEntity> BuscarLicencaPorEmpresa(int codigoEmpresa);
    }
}