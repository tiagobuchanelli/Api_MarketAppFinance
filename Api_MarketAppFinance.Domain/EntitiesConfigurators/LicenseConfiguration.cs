using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class LicenseConfiguration : IEntityTypeConfiguration<License>
    {
        public void Configure(EntityTypeBuilder<License> builder)
        {
            builder
               .ToTable("Licenses");
                   

            builder
                .Property(a => a.Description)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder
                .Property(a => a.Type)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(a => a.Key)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder
                .Property(a => a.ExpirationLicense)
                .HasColumnType("date")
                .IsRequired();

            builder
              .Property(a => a.CreateAt)
              .ValueGeneratedOnAdd()
              .HasDefaultValueSql("now()");

            builder
                .Property(a => a.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("now()")
                .IsRequired();

        }
    }
}
