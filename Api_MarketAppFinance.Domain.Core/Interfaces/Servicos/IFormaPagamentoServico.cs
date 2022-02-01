using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface IFormaPagamentoServico<TEntity> : IBaseServico<FormaPagamento>
    {
        TEntity AdicionarFormaPagamento(TEntity dados);

        TEntity AtualizarFormaPagamento(TEntity dados);

        List<TEntity> BuscarFormasPagamento(int codigoEmpresa);
    }
}