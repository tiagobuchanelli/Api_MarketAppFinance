using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace MarketAppFinanceSApi_MarketAppFinanceervice.Application
{
    public class UsuarioAplicacaoServico : IUsuarioAplicacaoServico
    {
        private readonly IUsuarioServico _serviceUser;
        private readonly IMapper _mapper;

        public UsuarioAplicacaoServico(IUsuarioServico serviceUser, IMapper mapper)
        {
            _serviceUser = serviceUser;
            _mapper = mapper;
        }

        public void Add(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            _serviceUser.Add(user);
        }

        public IEnumerable<UsuarioDto> GetAll()
        {
            var users = _serviceUser.GetAll();
            return _mapper.Map<IEnumerable<UsuarioDto>>(users);
        }

        public UsuarioDto GetById(int id)
        {
            var user = _serviceUser.GetById(id);
            return _mapper.Map<UsuarioDto>(user);
        }

        public void Remove(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            _serviceUser.Remove(user);
        }

        public void Update(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            _serviceUser.Update(user);
        }
    }
}