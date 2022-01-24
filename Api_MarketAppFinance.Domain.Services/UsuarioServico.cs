using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class UsuarioServico : ServicoBase<Usuario>, IUsuarioServico<Usuario>
    {
        #region Atributos
        private readonly IUsuarioRepositorio<Usuario> _repositorioUsuario;
        #endregion

        #region Construtores
        public UsuarioServico(IUsuarioRepositorio<Usuario> userRepository) : base(userRepository)
        {
            _repositorioUsuario = userRepository;
        }
        #endregion

        #region Metodos Privados

        #endregion

        #region Metodos Publicos
        public Usuario AdicionarUsuario(Usuario usuario)
        {
            var dadosUsuario = new Usuario(
                nome: usuario.Nome,
                sobrenome: usuario.Sobrenome,
                email: usuario.Email,
                documento: usuario.NumeroDocumento,
                telefone: usuario.Telefone,
                imagem: usuario.Imagem
                );
            
            Adicionar(dadosUsuario);
            return BuscarUsuarioPorDocumento(dadosUsuario.NumeroDocumento);
        }

        public Usuario BuscarUsuarioPorDocumento(string documento)
            => _repositorioUsuario.BuscarUsuarioPorDocumento(documento);
        #endregion

    }
}