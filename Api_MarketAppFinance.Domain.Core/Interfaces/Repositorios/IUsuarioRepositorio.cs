using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Interrfaces.Repositories
{
    public interface IUsuarioRepositorio<TEntity> : IBaseRepositorio<Usuario>
    {
        TEntity BuscarUsuarioPorDocumento(string documento);

        TEntity BuscarUsuarioPorEmail(string email);
    }
}