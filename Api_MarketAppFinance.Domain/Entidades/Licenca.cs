namespace Api_MarketAppFinance.Domain.Entities
{
    public class Licenca : Base
    {
        #region Constructos

        private Licenca()
        { }

        public Licenca(
            string descricao,
            string tipo,
            int numeroAcessosPermitido,
            DateTime dataValidade,
            Empresa empresa)
        {
            Descricao = descricao;
            Tipo = tipo;
            Chave = Guid.NewGuid().ToString();
            NumeroAcessosPermitido = numeroAcessosPermitido;
            DataExpiracao = dataValidade;
            EmpresaId = empresa.Id;

            Validar();
        }

        #endregion Constructos

        #region Actributes

        public string Descricao { get; private set; }

        public string Tipo { get; private set; }

        public string Chave { get; private set; }

        public int NumeroAcessosPermitido { get; private set; }

        public DateTime DataExpiracao { get; private set; }

        public int EmpresaId { get; private set; }

        #endregion Actributes

        #region Private Methods

        private void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");

            if (string.IsNullOrEmpty(Tipo))
                throw new Exception("Obrigatório informar o tipo.");

            if (DataExpiracao < DateTime.Now.Date)
                throw new Exception("Não é possível inserir data de validade menor que a data atual");
        }

        #endregion Private Methods

        #region Public Methods

        public void GerarChaveLicenca()
        {
            if (string.IsNullOrEmpty(Chave))
                throw new Exception("Não foi possível Gerar a Chave para essa Licença!");

            Chave = Guid.NewGuid().ToString();
        }

        #endregion Public Methods
    }
}