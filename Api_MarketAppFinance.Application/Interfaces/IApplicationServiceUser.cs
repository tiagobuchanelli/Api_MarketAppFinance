using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface IApplicationServiceUser
    {
        void Add(UserDto userDto);

        void Update(UserDto userDto);

        void Remove(UserDto userDto);

        IEnumerable<UserDto> GetAll();

        UserDto GetById(int id);
    }
}