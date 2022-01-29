using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Interrfaces.Repositories
{
    public interface IEmpresaRepositorio<TEntity> : IBaseRepositorio<Empresa>
    {
        TEntity BuscarEmpresaPorDocumento(string numeroDocumento);

        TEntity BuscarDadosCompletoEmpresa(string numeroDocumento);
    }
}