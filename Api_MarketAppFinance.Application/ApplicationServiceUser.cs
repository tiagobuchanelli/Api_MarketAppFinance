using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace MarketAppFinanceSApi_MarketAppFinanceervice.Application
{
    public class ApplicationServiceUser : IApplicationServiceUser
    {
        private readonly IServiceUser _serviceUser;
        private readonly IMapper _mapper;

        public ApplicationServiceUser(IServiceUser serviceUser, IMapper mapper)
        {
            _serviceUser = serviceUser;
            _mapper = mapper;
        }

        public void Add(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _serviceUser.Add(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = _serviceUser.GetAll();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public UserDto GetById(int id)
        {
            var user = _serviceUser.GetById(id);
            return _mapper.Map<UserDto>(user);
        }

        public void Remove(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _serviceUser.Remove(user);
        }

        public void Update(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _serviceUser.Update(user);
        }
    }
}