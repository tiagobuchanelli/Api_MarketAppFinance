namespace Api_MarketAppFinance.Domain.Entities
{
    public class Usuario : Base
    {
        #region Constructos

        private Usuario()
        {
        }

        public Usuario(
            string nome, 
            string sobrenome, 
            string email, 
            string documento, 
            string? telefone = null, 
            string? imagem = null)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Telefone = telefone;
            NumeroDocumento = documento;
            Imagem = imagem;
            Ativo = true;
        }

        #endregion Constructos

        #region Actributes Private
        
        #endregion Actributes Private

        #region Actributes Public

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }

        public string NumeroDocumento { get; private set; }

        public bool Ativo { get; private set; }

        public string? Telefone { get; private set; }

        public string? Imagem { get; private set; }


        #endregion Actributes Public

        #region Private Method        

        #endregion Private Method

        #region Metodos Publicos

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Obrigatório informar o nome do usuário.");

            if (string.IsNullOrEmpty(Sobrenome))
                throw new Exception("Obrigatório informar o sobre nome.");

            if (string.IsNullOrEmpty(Email))
                throw new Exception("Obrigatório informar o e-mail.");

            if (string.IsNullOrEmpty(NumeroDocumento))
                throw new Exception("Obrigatório informar o documento.");

        }

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void GerarDispositivoLicenca(LicencaDispositivo device)
        {
            
        }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Obrigatório informar o nome do usuário.");

            Nome = nome;
        }

        public void AlterarSobreNome(string sobrenome)
        {
            if (string.IsNullOrEmpty(sobrenome))
                throw new Exception("Obrigatório informar o sobrenome do usuário.");

            Sobrenome = sobrenome;
        }

        public void AlterarEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception("Obrigatório informar um e-mail válido");

            Email = email;
        }

        public void AlterarDocumento(string documento)
        {
            if (string.IsNullOrEmpty(documento))
                throw new Exception("Obrigatório informar um documento válido");

            NumeroDocumento = documento;
        }

        public void AlterarTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public void AlterarImagem(string imagem)
        {
            Imagem = imagem;
        }

        #endregion Metodos Publicos
    }
}