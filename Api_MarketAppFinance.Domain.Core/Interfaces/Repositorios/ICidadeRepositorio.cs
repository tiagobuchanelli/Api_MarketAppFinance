using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Interrfaces.Repositories
{
    public interface ICidadeRepositorio<TEntity> : IBaseRepositorio<Cidade>
    {
        TEntity BuscarCidadePorCodigoIbge(string codigoIbge);
    }
}