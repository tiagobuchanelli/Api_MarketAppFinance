namespace Api_MarketAppFinance.Domain.Entities
{
    public class Company : Base
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool IsActive { get; set; }

        public string? Phone { get; set; }

        public string? Image { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<License> Licenses { get; set; }
        

        
    }
}