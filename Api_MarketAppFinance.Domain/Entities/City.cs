namespace Api_MarketAppFinance.Domain.Entities
{
    public class City : Base
    {        
        public string Name { get; set; }

        public string? ZipCode { get; set; }

        public bool IsActive { get; set; }

        public int CodeIgbe { get; set; }

        public int StateCodeIgbe { get; set; }

        public string? StateSymbol { get; set; }

        public IEnumerable<Address>? Adresses { get; set; }
    }
}