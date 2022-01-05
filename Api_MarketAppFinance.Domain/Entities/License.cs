namespace Api_MarketAppFinance.Domain.Entities
{
    public class License : Base
    {
        #region Constructos

        private License()
        { }

        public License(string description, string type, int maxAcess, DateTime dateExpiration, Company company)
        {
           Description = description;
           Type = type;
           Key = Guid.NewGuid().ToString();
           MaxAcess = maxAcess;
           ExpirationLicense = dateExpiration; 
           CompanyId = company.Id;  

           Valdidate();
        }        

        #endregion Constructos

        #region Actributes

        public string Description { get; private set; }

        public string Type { get; private set; }

        public string Key { get; private set; }

        public int MaxAcess { get; private set; }

        public DateTime ExpirationLicense { get; private set; }

        public int CompanyId { get; private set; }

        public Company Company { get; private set; }

        #endregion

        #region Private Methods
        private void Valdidate()
        {
            if (string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Type))
                throw new Exception("Não é possível inserir valores vazio ou nulo");

            if (ExpirationLicense < DateTime.Now.Date)
                throw new Exception("Não é possível inserir data de validade menor que a data atual");
                        
        }

        #endregion

        #region Public Methods
        public void GenerateKey()
        {
            if (string.IsNullOrEmpty(Key))
                throw new Exception("Não foi possível Gerar a Chave para essa Licença!");

            Key = Guid.NewGuid().ToString();
        }
        #endregion

    }
}