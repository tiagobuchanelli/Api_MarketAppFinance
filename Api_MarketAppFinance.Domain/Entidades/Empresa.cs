namespace Api_MarketAppFinance.Domain.Entities
{
    public class Empresa : Base
    {
        #region Constructos

        private Empresa()
        { }

        public Empresa(string name, string shortName, string? phone, Usuario user)
        {
            Nome = name;
            NomeCurto = shortName;
            Telefone = phone;
            UsuarioId = user.Id;

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

        public bool IsActive { get; private set; }

        public string? Telefone { get; private set; }

        public string? Image { get; private set; }

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

        public void AlterarImagem(string imageCompany) => Image = imageCompany;

        public void AlterarTelefone(string phone) => Telefone = phone;

        public void Ativar() => IsActive = true;

        public void Inativar() => IsActive = true;

        public void GerarLicenca(Licenca license)
        {            
            _licenses.Add(license);
        }

        #endregion Public Methods
    }
}