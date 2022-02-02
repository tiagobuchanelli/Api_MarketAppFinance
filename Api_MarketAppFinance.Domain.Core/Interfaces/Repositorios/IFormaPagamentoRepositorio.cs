using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Interrfaces.Repositories
{
    public interface IFormaPagamentoRepositorio<TEntity> : IBaseRepositorio<FormaPagamento>
    {
        TEntity BuscarPorCodigo(int idEmpresa, int codigo);

        List<TEntity> BuscarTodos(int idEmpresa);

        List<TEntity> BuscarFormasPagamento(int idEmpresa);
    }
}