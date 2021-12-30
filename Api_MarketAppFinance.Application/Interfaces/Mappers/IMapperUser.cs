using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Application.Interfaces.Mappers
{
    public interface IMapperUser
    {
        User MapperDtoToEntity(UserDto userDto);

        IEnumerable<UserDto> MapperListUsersDto(IEnumerable<User> users);

        UserDto MapperEntityToDto(User user);
    }
}