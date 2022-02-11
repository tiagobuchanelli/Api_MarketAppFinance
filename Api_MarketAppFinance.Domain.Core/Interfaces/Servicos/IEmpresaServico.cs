using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface IEmpresaServico<TEntity> : IBaseServico<Empresa>
    {
        TEntity AdicionarEmpresa(TEntity dados);

        TEntity AtualizarEmpresa(TEntity dados);

        TEntity BuscarInformacoesEmpresa(string documento);

        void ValidarChaveApiEmpresa(int idEmpresa, string chave);

        List<TEntity> BuscarTodos();

        TEntity BuscarPorCodigo(int codigo);
    }
}