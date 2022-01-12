namespace Api_MarketAppFinance.Domain.Entities
{
    public class Endereco : Base
    {
        #region Constructos
        private Endereco()
        {
        }

        public Endereco(string rua, Usuario usuario, Cidade cidade, string? numero = null, string? cep = null, string? bairro = null, string? complemento = null)
        {
            this.Rua = rua;
            this.Numero = numero;   
            this.Cep = cep;  
            this.Bairro = bairro;
            this.Complemento = complemento;
            this.UsuarioId = usuario.Id;
            this.CidadeId = cidade.Id;

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