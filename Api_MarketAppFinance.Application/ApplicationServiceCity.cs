
using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Application.Interfaces.Mappers;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;

namespace Api_MarketAppFinance.Application
{
    public class ApplicationServiceCity : IApplicationServiceCity
    {
        private readonly IServiceCity _serviceCity;
        private readonly IMapperCity _mapperCity;

        public ApplicationServiceCity(IServiceCity serviceCity, IMapperCity mapperCity)
        {
            _serviceCity = serviceCity;
            _mapperCity = mapperCity;
        }

        public void Add(CityDto cityDto)
        {
            var city = _mapperCity.MapperDtoToEntity(cityDto);
            _serviceCity.Add(city);
        }

        public IEnumerable<CityDto> GetAll()
        {
            var cities = _serviceCity.GetAll();
            return _mapperCity.MapperListCitiesDto(cities);
        }

        public CityDto GetById(int id)
        {
            var city = _serviceCity.GetById(id);
            return _mapperCity.MapperEntityToDto(city);
        }

        public void Remove(CityDto cityDto)
        {
            var city = _mapperCity.MapperDtoToEntity(cityDto);
            _serviceCity.Remove(city);
        }

        public void Update(CityDto cityDto)
        {
            var city = _mapperCity.MapperDtoToEntity(cityDto);
            _serviceCity.Update(city);
        }
    }
}