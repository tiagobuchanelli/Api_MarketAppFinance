namespace Api_MarketAppFinance.Domain.Entities
{
    public class City : Base
    {
        public string Name { get; set; }

        public string? ZipCode { get; set; }

        public bool IsActive { get; set; }

        public string CodeIgbe { get; set; }

        public string StateCodeIgbe { get; set; }

        public string? StateSymbol { get; set; }

        //public IEnumerable<Address>? Adresses { get; set; }
    }
}