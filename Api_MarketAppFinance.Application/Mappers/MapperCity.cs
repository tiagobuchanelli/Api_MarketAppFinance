
using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces.Mappers;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class MapperCity : IMapperCity
    {
        private IEnumerable<CityDto> userDtos = new List<CityDto>();

        public City MapperDtoToEntity(CityDto cityDto)
        {
            var city = new City()
            {
                Id = cityDto.Id,
                Name = cityDto.NameCity
            };

            return city;
        }

        public CityDto MapperEntityToDto(City city)
        {
            var cityDto = new CityDto()
            {
                Id = city.Id,
                NameCity = city.Name
            };

            return cityDto;
        }

        public IEnumerable<CityDto> MapperListCitiesDto(IEnumerable<City> cities)
        {
            var citiesDto = cities.Select(x => new CityDto { Id = x.Id, NameCity = x.Name });
            return citiesDto;
        }
    }
}