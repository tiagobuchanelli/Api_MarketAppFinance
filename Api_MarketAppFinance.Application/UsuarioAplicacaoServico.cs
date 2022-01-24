using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace MarketAppFinanceSApi_MarketAppFinanceervice.Application
{
    public class UsuarioAplicacaoServico : IUsuarioAplicacaoServico
    {
        private readonly IUsuarioServico<Usuario> _servicoUsuario;
        private readonly IMapper _mapper;

        public UsuarioAplicacaoServico(IUsuarioServico<Usuario> serviceUser, IMapper mapper)
        {
            _servicoUsuario = serviceUser;
            _mapper = mapper;
        }

        public UsuarioDto Adicionar(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            var dadosUsuario = _servicoUsuario.AdicionarUsuario(user);
            
            return _mapper.Map<UsuarioDto>(dadosUsuario);

        }

        public IEnumerable<UsuarioDto> BuscarTodos()
        {
            var users = _servicoUsuario.BuscarTodos();
            return _mapper.Map<IEnumerable<UsuarioDto>>(users);
        }

        public UsuarioDto BuscarPorCodigo(int id)
        {
            var user = _servicoUsuario.BuscarPorCodigo(id);
            return _mapper.Map<UsuarioDto>(user);
        }

        public void Excluir(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            _servicoUsuario.Excluir(user);
        }

        public UsuarioDto Atualizar(UsuarioDto userDto)
        {
            var user = _mapper.Map<Usuario>(userDto);
            _servicoUsuario.Atualizar(user);
            var dadosUsuario = _servicoUsuario.BuscarUsuarioPorDocumento(user.NumeroDocumento);
            
            return _mapper.Map<UsuarioDto>(dadosUsuario);

        }
    }
}