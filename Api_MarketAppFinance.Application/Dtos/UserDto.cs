﻿namespace Api_MarketAppFinance.Application.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string? Image { get; set; }

        public string? Phone { get; set; }
    }
}