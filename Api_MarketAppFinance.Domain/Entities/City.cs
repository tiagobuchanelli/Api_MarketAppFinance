namespace Api_MarketAppFinance.Domain.Entities
{
    public class City : Base
    {
        #region Constructos
        private City()
        {
        }

        public City(string name, string zipCode, string codeIbge, string stateCodeIbge, string stateSymbol)
        {
            this.Name = name;
            this.ZipCode = zipCode;
            this.CodeIgbe = codeIbge;
            this.StateCodeIgbe = stateCodeIbge;
            this.StateSymbol = stateSymbol;
            this.IsActive = true;           

            Validate();
        }        

        #endregion

        #region Actributes Public
        public string Name { get; private set; }

        public string? ZipCode { get; private set; }

        public bool IsActive { get; private set; }

        public string CodeIgbe { get; private set; }

        public string StateCodeIgbe { get; private set; }

        public string? StateSymbol { get; private set; }
        #endregion

        #region Private Methods
        private void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Obrigatório informar o nome.");

            if(string.IsNullOrEmpty(CodeIgbe))
                throw new Exception("Obrigatório informar o código ibge.");

            if (string.IsNullOrEmpty(StateCodeIgbe))
                throw new Exception("Obrigatório informar o códigto ibge do estado.");

        }
        #endregion

        #region Public Methods
        public void SetStatus(bool status) => IsActive = status;
        #endregion

       
    }
}