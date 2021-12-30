using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Application.Interfaces.Mappers
{
    public interface IMapperCity
    {
        City MapperDtoToEntity(CityDto cityDto);

        IEnumerable<CityDto> MapperListCitiesDto(IEnumerable<City> cities);

        CityDto MapperEntityToDto(City city);
    }
}