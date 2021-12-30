using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class ServiceCity : ServiceBase<City>, IServiceCity
    {
        private readonly IRepositoryCity _cityRepository;

        public ServiceCity(IRepositoryCity userRepository) : base(userRepository)
        {
            this._cityRepository = userRepository;
        }
    }
}