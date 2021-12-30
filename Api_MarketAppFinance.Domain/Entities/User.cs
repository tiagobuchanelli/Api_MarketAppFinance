namespace Api_MarketAppFinance.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}