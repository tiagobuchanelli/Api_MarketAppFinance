using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class UsuarioServico : BaseServico<Usuario>, IUsuarioServico
    {
        private readonly IUsuarioRepositorio _userRepository;

        public UsuarioServico(IUsuarioRepositorio userRepository) : base(userRepository)
        {
            this._userRepository = userRepository;
        }
    }
}