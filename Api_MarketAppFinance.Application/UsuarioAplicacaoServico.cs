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

        public IEnumerable<UsuarioDto> BuscarTodos()
        => _mapper.Map<IEnumerable<UsuarioDto>>(_servicoUsuario.BuscarTodos());

        public UsuarioDto BuscarPorCodigo(int id)
        => _mapper.Map<UsuarioDto>(_servicoUsuario.BuscarPorCodigo(id));

        public UsuarioDto Adicionar(UsuarioDto userDto)
        {
            var dadosUsuario = _servicoUsuario.AdicionarUsuario(_mapper.Map<Usuario>(userDto));            
            return _mapper.Map<UsuarioDto>(dadosUsuario);

        }

        public UsuarioDto Atualizar(UsuarioDto userDto)
        {
            var dadosUsuario = _servicoUsuario.AtualizarUsuario(_mapper.Map<Usuario>(userDto));
            return _mapper.Map<UsuarioDto>(dadosUsuario);
        }

        public void Excluir(UsuarioDto userDto)
        => _servicoUsuario.Excluir(_mapper.Map<Usuario>(userDto));

        
       
    }
}