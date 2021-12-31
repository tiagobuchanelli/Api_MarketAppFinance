﻿using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
               .ToTable("Adresses");

            builder
                .Property(a => a.Street)
                .HasColumnType("varchar(300)")
                .IsRequired();
                        
        }
    }
}