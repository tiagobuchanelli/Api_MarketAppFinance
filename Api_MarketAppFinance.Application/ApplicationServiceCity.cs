using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application
{
    public class ApplicationServiceCity : IApplicationServiceCity
    {
        private readonly IServiceCity _serviceCity;
        private readonly IMapper _mapper;

        public ApplicationServiceCity(IServiceCity serviceCity, IMapper mapper)
        {
            _serviceCity = serviceCity;
            _mapper = mapper;
        }

        public void Add(CityDto cityDto)
        {
            var city = _mapper.Map<City>(cityDto);
            _serviceCity.Add(city);
        }

        public IEnumerable<CityDto> GetAll()
        {
            var cities = _serviceCity.GetAll();
            return _mapper.Map<IEnumerable<CityDto>>(cities);
        }

        public CityDto GetById(int id)
        {
            var city = _serviceCity.GetById(id);
            return _mapper.Map<CityDto>(city);
        }

        public void Remove(CityDto cityDto)
        {
            var city = _mapper.Map<City>(cityDto);
            _serviceCity.Remove(city);
        }

        public void Update(CityDto cityDto)
        {
            var city = _mapper.Map<City>(cityDto);
            _serviceCity.Update(city);
        }
    }
}