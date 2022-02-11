namespace Api_MarketAppFinance.Domain.Entities
{
    public class Endereco : Base
    {
        #region Constructos

        private Endereco()
        {
        }

        public Endereco(
            string rua, int
            codigoEntidade,
            Cidade cidade,
            Empresa empresa,
            string? numero = null,
            string? cep = null,
            string? bairro = null,
            string? complemento = null
            )
        {
            EmpresaId = empresa.Id;
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Complemento = complemento;
            CodigoEntidade = codigoEntidade;
            CidadeId = cidade.Id;
        }

        #endregion Constructos

        #region Actributes Public

        public int CodigoEntidade { get; private set; }

        public int CidadeId { get; private set; }

        public string Rua { get; private set; }

        public string? Numero { get; private set; }

        public string? Cep { get; private set; }

        public string? Bairro { get; private set; }

        public string? Complemento { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Usuario Usuario { get; private set; }

        public Cidade Cidade { get; private set; }

        #endregion Actributes Public

        #region Private Methods

        #endregion Private Methods

        #region Public Methods

        public void Validar()
        {
            if (string.IsNullOrEmpty(Rua))
                throw new Exception("Obrigatório informar a rua.");

            if (CodigoEntidade == default)
                throw new Exception("Obrigatório informar um usuário válido");

            if (CidadeId == default)
                throw new Exception("Obrigatório informar um usuário válido");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }

        public void AlterarRua(string rua)
        {
            if (string.IsNullOrEmpty(rua))
                throw new Exception("Obrigatório informar a rua.");
            Rua = rua;
        }

        public void AlterarNumero(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                throw new Exception("Obrigatório informar um número válido.");

            Numero = numero;
        }

        public void AlterarCep(string cep)
        {
            if (string.IsNullOrEmpty(cep))
                throw new Exception("Obrigatório informar um cep válido.");

            Cep = cep;
        }

        public void AlterarBairro(string bairro)
        {
            if (string.IsNullOrEmpty(bairro))
                throw new Exception("Obrigatório informar um bairro válido.");

            Bairro = bairro;
        }

        public void AlterarComplemento(string complemento)
        {
            if (string.IsNullOrEmpty(complemento))
                throw new Exception("Obrigatório informar um complemento válido.");

            Complemento = complemento;
        }

        #endregion Public Methods
    }
}