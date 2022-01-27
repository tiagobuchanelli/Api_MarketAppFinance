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

        public Usuario AtualizarUsuario(Usuario usuario)
        {
            var dadosUsuario = BuscarPorCodigo(usuario.Id);

            if (dadosUsuario.NumeroDocumento != usuario.NumeroDocumento)
                dadosUsuario.AlterarDocumento(usuario.NumeroDocumento);

            if(dadosUsuario.Nome != usuario.Nome)
                dadosUsuario.AlterarNome(usuario.Nome);
            
            if(dadosUsuario.Sobrenome != usuario.Sobrenome)
                dadosUsuario.AlterarSobreNome(usuario.Sobrenome);
            
            if(dadosUsuario.Email != usuario.Email)
                dadosUsuario.AlterarEmail(usuario.Email);
            
            if(dadosUsuario.Imagem != usuario.Imagem)
                dadosUsuario.AlterarImagem(usuario.Imagem);

            if(dadosUsuario.Telefone != usuario.Telefone)
                dadosUsuario.AlterarTelefone(usuario.Telefone);            

            Atualizar(dadosUsuario);

            return dadosUsuario;
        }        

        #endregion

    }
}