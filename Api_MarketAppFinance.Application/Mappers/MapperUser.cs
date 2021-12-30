
using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces.Mappers;
using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class MapperUser : IMapperUser
    {
        private IEnumerable<UserDto> userDtos = new List<UserDto>();

        public User MapperDtoToEntity(UserDto userDto)
        {
            var user = new User()
            {
                Id = userDto.Id,
                Name = userDto.Name,
                LastName = userDto.LastName,
            };

            return user;
        }

        public UserDto MapperEntityToDto(User user)
        {
            var userDto = new UserDto()
            {
                Id = user.Id,
                Name = user.Name,
                LastName = user.LastName,
            };

            return userDto;
        }

        public IEnumerable<UserDto> MapperListUsersDto(IEnumerable<User> users)
        {
            var usersDto = users.Select(x => new UserDto { Id = x.Id, Name = x.Name, LastName = x.LastName });

            return usersDto;
        }
    }
}