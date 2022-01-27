namespace Api_MarketAppFinance.Domain.Entities
{
    public class Cidade : Base
    {
        #region Constructos

        private Cidade()
        {
        }

        public Cidade(string nomeCidade, string codigoIbge, string codigoIbgeEstado, string? sigla = null, string? cep = null)
        {
            Nome = nomeCidade;
            Cep = cep;
            CodigoIbge = codigoIbge;
            CodigoIbgeEstado = codigoIbgeEstado;
            SiglaEstado = sigla;
            Ativo = true;

            Validar();
        }

        #endregion Constructos

        #region Actributes Public

        public string Nome { get; private set; }

        public string? Cep { get; private set; }

        public bool Ativo { get; private set; }

        public string CodigoIbge { get; private set; }

        public string CodigoIbgeEstado { get; private set; }

        public string? SiglaEstado { get; private set; }

        #endregion Actributes Public

        #region Private Methods

        private void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Obrigatório informar o nome.");

            if (string.IsNullOrEmpty(CodigoIbge))
                throw new Exception("Obrigatório informar o código ibge.");

            if (string.IsNullOrEmpty(CodigoIbgeEstado))
                throw new Exception("Obrigatório informar o códigto ibge do estado.");
        }

        #endregion Private Methods

        #region Public Methods

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarNomeCidade(string nomeCidade)
        {
            if (string.IsNullOrEmpty(nomeCidade))
                throw new Exception("Obrigatório informar um nome válido.");

            Nome = nomeCidade;
        }

        public void AlterarCodigoIbge(string ibge)
        {
            if (string.IsNullOrEmpty(ibge))
                throw new Exception("Obrigatório informar um codigo válido.");

            CodigoIbge = ibge;
        }

        public void AlterarCodigoIbgeEstado(string ibgeEstado)
        {
            if (string.IsNullOrEmpty(ibgeEstado))
                throw new Exception("Obrigatório informar um codigo válido.");

            CodigoIbgeEstado = ibgeEstado;
        }

        public void AlterarSiglaEstado(string siglaEstado)
        {            
            SiglaEstado = siglaEstado;
        }

        public void AlterarCep(string cep)
        {
            Cep = cep;
        }

        #endregion Public Methods
    }
}