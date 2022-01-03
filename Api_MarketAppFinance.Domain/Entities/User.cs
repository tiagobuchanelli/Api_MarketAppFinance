namespace Api_MarketAppFinance.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string? DocumentNumber { get; set; }

        public bool IsActive { get; set; }

        public string? Phone { get; set; }

        public string? Image { get; set; }

        public IEnumerable<Address>? Adresses { get; set; }

        public IEnumerable<Device>? Devices { get; set; }



    }
}