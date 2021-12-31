﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entities
{
    public class Address : Base
    {
        public int UserId { get; set; }

        public int CityId { get; set; }

        public string Street { get; set; }

        public string? StreetNumber { get; set; }

        public string? ZipCode { get; set; }

        public string? District { get; set; }

        public string? Complement { get; set; }

        public User? User { get; set; }

        public City? City { get; set; }

    }
}
