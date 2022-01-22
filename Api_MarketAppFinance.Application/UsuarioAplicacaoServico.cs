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

        public void Adicionar(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            _serviceUser.Adicionar(user);
        }

        public IEnumerable<UsuarioDto> BuscarTodos()
        {
            var users = _serviceUser.BuscarTodos();
            return _mapper.Map<IEnumerable<UsuarioDto>>(users);
        }

        public UsuarioDto BuscarPorCodigo(int id)
        {
            var user = _serviceUser.BuscarPorCodigo(id);
            return _mapper.Map<UsuarioDto>(user);
        }

        public void Excluir(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            _serviceUser.Excluir(user);
        }

        public void Atualizar(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            _serviceUser.Atualizar(user);
        }
    }
}