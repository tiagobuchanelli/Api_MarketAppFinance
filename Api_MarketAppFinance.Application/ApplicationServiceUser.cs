using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Application.Interfaces.Mappers;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;

namespace MarketAppFinanceSApi_MarketAppFinanceervice.Application
{
    public class ApplicationServiceUser : IApplicationServiceUser
    {
        private readonly IServiceUser _serviceUser;
        private readonly IMapperUser _mapperUser;

        public ApplicationServiceUser(IServiceUser serviceUser, IMapperUser mapperUser)
        {
            _serviceUser = serviceUser;
            _mapperUser = mapperUser;
        }

        public void Add(UserDto userDto)
        {
            var user = _mapperUser.MapperDtoToEntity(userDto);
            _serviceUser.Add(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = _serviceUser.GetAll();
            return _mapperUser.MapperListUsersDto(users);
        }

        public UserDto GetById(int id)
        {
            var user = _serviceUser.GetById(id);
            return _mapperUser.MapperEntityToDto(user);
        }

        public void Remove(UserDto userDto)
        {
            var user = _mapperUser.MapperDtoToEntity(userDto);
            _serviceUser.Remove(user);
        }

        public void Update(UserDto userDto)
        {
            var user = _mapperUser.MapperDtoToEntity(userDto);
            _serviceUser.Update(user);
        }
    }
}