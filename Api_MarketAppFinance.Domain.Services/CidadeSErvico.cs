using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class CidadeSErvico : BaseServico<Cidade>, ICidadeSErvico
    {
        private readonly ICidadeRepositorio _cityRepository;

        public CidadeSErvico(ICidadeRepositorio userRepository) : base(userRepository)
        {
            this._cityRepository = userRepository;
        }
    }
}