namespace Api_MarketAppFinance.Domain.Entities
{
    public class Empresa : Base
    {
        #region Constructos

        private Empresa()
        { }

        public Empresa(string nomeFantasia, string razaoSocial, string numeroDocumento, int usuarioId, string? telefone = null, string? imagem = null)
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            NumeroDocumento = numeroDocumento;
            Telefone = telefone;
            UsuarioId = usuarioId;
            Ativo = true;
            Imagem = imagem;
            ChaveApi = Guid.NewGuid().ToString();
        }

        #endregion Constructos

        #region Actributes Private

        #endregion Actributes Private

        #region Actributes Public

        public string NomeFantasia { get; private set; }

        public string ChaveApi { get; private set; }

        public string RazaoSocial { get; private set; }

        public string NumeroDocumento { get; private set; }

        public bool Ativo { get; private set; }

        public string? Telefone { get; private set; }

        public string? Imagem { get; private set; }

        public int UsuarioId { get; private set; }

        public Usuario Usuario { get; private set; }

        public IReadOnlyCollection<Licenca> Licencas { get; private set; }

        #endregion Actributes Public

        #region Private Methods        

        #endregion Private Methods

        #region Public Methods
        
        public void Validar()
        {
            if (string.IsNullOrEmpty(NomeFantasia))
                throw new Exception("Obrigatório informar o nome da empresa.");

            if (string.IsNullOrEmpty(RazaoSocial))
                throw new Exception("Obrigatório informar o nome curto da empresa.");

            if (string.IsNullOrEmpty(NumeroDocumento))
                throw new Exception("Obrigatório informar o documento da empresa.");

            if (UsuarioId == default)
                throw new Exception("Obrigatório informar um usuário valido");
        }

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarImagem(string imagem) => Imagem = imagem;

        public void AlterarTelefone(string telefone) => Telefone = telefone;

        public void AlterarNomeFantasia(string nomeEmpresa)
        {
            if (string.IsNullOrEmpty(nomeEmpresa))
                throw new Exception("Obrigatório informar um nome válido.");

            NomeFantasia = nomeEmpresa;
            
        }

        public void AlterarRazãoSocial(string razaoSocial)
        {
            if (string.IsNullOrEmpty(razaoSocial))
                throw new Exception("Obrigatório informar um nome válido válido.");

            RazaoSocial = razaoSocial;
        }

        public void AlterarNumeroDocumento(string numeroDocumento)
        {
            if (string.IsNullOrEmpty(numeroDocumento))
                throw new Exception("Obrigatório informar um documento válido válido.");

            NumeroDocumento = numeroDocumento;
        }

        #endregion Public Methods
    }
}