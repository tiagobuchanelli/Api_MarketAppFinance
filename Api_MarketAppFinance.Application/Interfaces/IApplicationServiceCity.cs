using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface IApplicationServiceCity
    {
        void Add(CityDto cityDto);

        void Update(CityDto cityDto);

        void Remove(CityDto cityDto);

        IEnumerable<CityDto> GetAll();

        CityDto GetById(int id);
    }
}