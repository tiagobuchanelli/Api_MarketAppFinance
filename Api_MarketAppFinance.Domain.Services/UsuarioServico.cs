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
        private Usuario BuscarUsuarioPorDocumento(string documento)
            => _repositorioUsuario.BuscarUsuarioPorDocumento(documento);
        #endregion

        #region Metodos Publicos
        public Usuario BuscarUsuarioPorEmail(string email)
        {
            return _repositorioUsuario.BuscarUsuarioPorEmail(email);
        }

        public string GerarToken(string email)
        {
            return TokenServico.GenerateToken(email);
        }

        public Usuario AdicionarUsuario(Usuario dadosUsuario)
        {
            dadosUsuario.Validar();

            Adicionar(dadosUsuario);
            return BuscarUsuarioPorDocumento(dadosUsuario.NumeroDocumento);
        }

        public Usuario AtualizarUsuario(Usuario usuario)
        {
            var dadosUsuario = BuscarPorCodigo(usuario.Id);

            dadosUsuario.AlterarDocumento(usuario.NumeroDocumento);                        
            dadosUsuario.AlterarNome(usuario.Nome);
            dadosUsuario.AlterarSobreNome(usuario.Sobrenome);
            dadosUsuario.AlterarEmail(usuario.Email);
            dadosUsuario.AlterarImagem(usuario.Imagem);
            dadosUsuario.AlterarTelefone(usuario.Telefone);            

            Atualizar(dadosUsuario);

            return dadosUsuario;
        }

        public List<Usuario> BuscarTodos()
        => _repositorioUsuario.BuscarTodos();

        public Usuario BuscarPorCodigo(int codigo)
        => _repositorioUsuario.BuscarPorCodigo(codigo);


        #endregion

    }
}