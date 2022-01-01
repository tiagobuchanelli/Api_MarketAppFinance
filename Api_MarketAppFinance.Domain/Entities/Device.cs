using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entities
{
    public class Device : Base
    {
        public string Name { get; set; }

        public string Key { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
