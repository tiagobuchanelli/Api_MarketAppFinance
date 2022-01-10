namespace Api_MarketAppFinance.Domain.Entities
{
    public class Endereco : Base
    {
        #region Constructos
        private Endereco()
        {
        }

        public Endereco(string street, string streetNumber, string zipCode, string district, string complement, Usuario user, Cidade city)
        {
            this.Rua = street;
            this.Numero = streetNumber;   
            this.Cep = zipCode;  
            this.Bairro = district;
            this.Complemento = complement;
            this.UsuarioId = user.Id;
            this.CidadeId = city.Id;

            Validar();

        }

        #endregion

        #region Actributes Public

        public int UsuarioId { get; private set; }

        public int CidadeId { get; private set; }

        public string Rua { get; private set; }

        public string? Numero { get; private set; }

        public string? Cep { get; private set; }

        public string? Bairro { get; private set; }

        public string? Complemento { get; private set; }

        public Usuario Usuario { get; private set; }

        public Cidade Cidade { get; private set; }

        #endregion

        #region Private Methods
        private void Validar()
        {
            if(string.IsNullOrEmpty(Rua))
                throw new Exception("Obrigatório informar a rua.");

            if (UsuarioId == default)
                throw new Exception("Obrigatório informar um usuário válido");

            if(CidadeId == default)
                throw new Exception("Obrigatório informar um usuário válido");

        }
        #endregion

        #region Public Methods
        public void AlterarRua(string street) => Rua = street;
        public void AlterarNumero(string streetNumber) => Numero = streetNumber;
        public void AlterarCep(string zipCode) => Cep = zipCode;
        public void AlterarBairro(string district) => Bairro = district;
        public void AlterarComplemento(string complement) => Complemento = complement;
        #endregion
    }
}