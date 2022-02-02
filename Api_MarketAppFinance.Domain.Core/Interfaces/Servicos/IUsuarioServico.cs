using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface IUsuarioServico<TEntity> : IBaseServico<Usuario>
    {
        TEntity AdicionarUsuario(TEntity dados);

        TEntity AtualizarUsuario(TEntity dados);

        TEntity BuscarUsuarioPorEmail(string email);

        string GerarToken(string dados);

        List<TEntity> BuscarTodos();

        TEntity BuscarPorCodigo(int codigo);

    }
}