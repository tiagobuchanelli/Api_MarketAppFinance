using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Core.Interfaces.Services
{
    public interface IUsuarioServico<TEntity> : IBaseServico<Usuario>
    {
        TEntity AdicionarUsuario(TEntity dados);

        TEntity BuscarUsuarioPorDocumento(string dados);
    }
}