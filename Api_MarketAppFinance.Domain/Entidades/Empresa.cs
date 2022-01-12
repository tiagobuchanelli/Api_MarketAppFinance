namespace Api_MarketAppFinance.Domain.Entities
{
    public class Empresa : Base
    {
        #region Constructos

        private Empresa()
        { }

        public Empresa(string name, string nomeCurto, Usuario usuario, string? telefone = null, string? imagem = null)
        {
            Nome = name;
            NomeCurto = nomeCurto;
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

        #endregion

        #region Actributes Public

        public string Nome { get; private set; }

        public string NomeCurto { get; private set; }

        public bool Ativo { get; private set; }

        public string? Telefone { get; private set; }

        public string? Imagem { get; private set; }

        public int UsuarioId { get; private set; }

        public Usuario Usuario { get; private set; }

        public IReadOnlyCollection<Licenca> Licenses { get { return _licenses.ToList(); } }

        #endregion Actributes

        #region Private Methods

        private void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Obrigatório informar o nome da empresa.");

            if(string.IsNullOrEmpty(NomeCurto))
                throw new Exception("Obrigatório informar o nome curto da empresa.");

            if (UsuarioId == default)
                throw new Exception("Obrigatório informar um usuário valido");
        }

        #endregion Private Methods

        #region Public Methods

        public void AlterarImagem(string imageCompany) => Imagem = imageCompany;

        public void AlterarTelefone(string phone) => Telefone = phone;

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void GerarLicenca(Licenca license)
        {            
            if(license is null)
                throw new Exception("Obrigatório informar uma licença válida.");

            _licenses.Add(license);
        }

        #endregion Public Methods
    }
}