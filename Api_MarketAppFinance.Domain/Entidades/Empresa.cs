namespace Api_MarketAppFinance.Domain.Entities
{
    public class Empresa : Base
    {
        #region Constructos

        private Empresa()
        { }

        public Empresa(string nomeFantasia, string razaoSocial, Usuario usuario, string? telefone = null, string? imagem = null)
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Telefone = telefone;
            UsuarioId = usuario.Id;
            Ativo = true;
            Imagem = imagem;

            _licenses = new List<Licenca>();

            Validar();
        }

        #endregion Constructos

        #region Actributes Private

        private IList<Licenca> _licenses;

        #endregion Actributes Private

        #region Actributes Public

        public string NomeFantasia { get; private set; }

        public string RazaoSocial { get; private set; }

        public bool Ativo { get; private set; }

        public string? Telefone { get; private set; }

        public string? Imagem { get; private set; }

        public int UsuarioId { get; private set; }

        public Usuario Usuario { get; private set; }

        public IReadOnlyCollection<Licenca> Licenses
        { get { return _licenses.ToList(); } }

        #endregion Actributes Public

        #region Private Methods

        private void Validar()
        {
            if (string.IsNullOrEmpty(NomeFantasia))
                throw new Exception("Obrigatório informar o nome da empresa.");

            if (string.IsNullOrEmpty(RazaoSocial))
                throw new Exception("Obrigatório informar o nome curto da empresa.");

            if (UsuarioId == default)
                throw new Exception("Obrigatório informar um usuário valido");
        }

        #endregion Private Methods

        #region Public Methods

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarImagem(string imagem)
        {
            if (string.IsNullOrEmpty(imagem))
                throw new Exception("Obrigatório informar uma imagem válida.");

            Imagem = imagem;
        }

        public void AlterarTelefone(string telefone)
        {
            if (string.IsNullOrEmpty(telefone))
                throw new Exception("Obrigatório informar um telefone válido.");

            Telefone = telefone;
        }

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

        public void GerarLicenca(Licenca license)
        {
            if (license is null)
                throw new Exception("Obrigatório informar uma licença válida.");

            _licenses.Add(license);
        }

        #endregion Public Methods
    }
}