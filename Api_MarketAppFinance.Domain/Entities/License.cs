using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entities
{
    public class License : Base
    {
        public string Description { get; set; }

        public string Type { get; set; }

        public string Key { get; set; }

        public int MaxAcess { get; set; }

        public DateTime ExpirationLicense { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
