namespace Api_MarketAppFinance.Domain.Entities
{
    public class Usuario : Base
    {
        #region Constructos
        private Usuario()
        {
        }

        public Usuario(string nome, string sobrenome, string email, string? documento = null, string? telefone = null, string? imagem = null)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Telefone = telefone;
            NumeroDocumento = documento;
            Imagem = imagem;

            _dispositivos = new List<LicencaDispositivo>();
            _enderecos = new List<Endereco>();

            Validate();
        }

        

        #endregion

        #region Actributes Private

        private IList<LicencaDispositivo> _dispositivos;
        private IList<Endereco> _enderecos;

        #endregion

        #region Actributes Public
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Email { get; private set; }

        public string? NumeroDocumento { get; private set; }

        public bool Ativo { get; private set; }

        public string? Telefone { get; private set; }

        public string? Imagem { get; private set; }        

        public IEnumerable<Endereco> Adresses { get { return _enderecos.ToList(); } }

        public IEnumerable<LicencaDispositivo> Devices { get { return _dispositivos.ToList(); } }
        #endregion

        #region Private Method
        private void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Obrigatório informar o nome do usuário.");

            if (string.IsNullOrEmpty(Sobrenome))
                throw new Exception("Obrigatório informar o sobre nome.");

            if (string.IsNullOrEmpty(Email))
                throw new Exception("Obrigatório informar o e-mail.");

        }
        #endregion

        #region Public Methods
        public void GerarEndereco(Endereco address)
        {
            _enderecos.Add(address);
        }

        public void GerarDispositivoLicenca(LicencaDispositivo device)
        {
            _dispositivos.Add(device);
        }
        #endregion

        #region Metodos Publicos
        public void AlterarNome(string n) => Nome = n;
        public void AlterarSobreNome(string s) => Sobrenome = s;
        public void AlterarEmail(string e) => Email = e;
        public void AlterarDocumento(string d) => NumeroDocumento = d;
        public void AlterarStatus(bool s) => Ativo = s;
        public void AlterarTelefone(string t) => Telefone = t;
        public void AlterarImagem(string i) => Imagem = i;
        #endregion



    }
}