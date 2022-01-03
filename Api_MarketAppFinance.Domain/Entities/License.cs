namespace Api_MarketAppFinance.Domain.Entities
{
    public class License : Base
    {
        public string Description { get; set; }

        public string Type { get; set; }

        public string Key { get; set; }

        public int MaxAcess { get; set; }

        public DateTime ExpirationLicense { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}