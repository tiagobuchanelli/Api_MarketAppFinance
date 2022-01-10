namespace Api_MarketAppFinance.Domain.Entities
{
    public class Cidade : Base
    {
        #region Constructos
        private Cidade()
        {
        }

        public Cidade(string name, string zipCode, string codeIbge, string stateCodeIbge, string stateSymbol)
        {
            this.Nome = name;
            this.Cep = zipCode;
            this.CdIbge = codeIbge;
            this.CdIbgeEstado = stateCodeIbge;
            this.SiglaEstado = stateSymbol;
            this.Ativo = true;           

            Validar();
        }        

        #endregion

        #region Actributes Public
        public string Nome { get; private set; }

        public string? Cep { get; private set; }

        public bool Ativo { get; private set; }

        public string CdIbge { get; private set; }

        public string CdIbgeEstado { get; private set; }

        public string? SiglaEstado { get; private set; }
        #endregion

        #region Private Methods
        private void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Obrigatório informar o nome.");

            if(string.IsNullOrEmpty(CdIbge))
                throw new Exception("Obrigatório informar o código ibge.");

            if (string.IsNullOrEmpty(CdIbgeEstado))
                throw new Exception("Obrigatório informar o códigto ibge do estado.");

        }
        #endregion

        #region Public Methods
        public void AlterarStatus(bool status) => Ativo = status;
        #endregion

       
    }
}