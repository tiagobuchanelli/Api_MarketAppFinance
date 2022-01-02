﻿namespace Api_MarketAppFinance.Domain.Entities
{
    public class LicensesAccessControll : Base
    {
        public string Description { get; set; }

        public int LicenseId { get; set; }

        public int DeviceId { get; set; }

        public License License { get; set; }

        public Device Device { get; set; }
    }
}