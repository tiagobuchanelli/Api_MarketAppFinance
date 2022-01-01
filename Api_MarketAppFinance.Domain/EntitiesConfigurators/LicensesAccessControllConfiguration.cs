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
    public class LicensesAccessControllConfiguration : IEntityTypeConfiguration<LicensesAccessControll>
    {
        public void Configure(EntityTypeBuilder<LicensesAccessControll> builder)
        {
            builder
               .ToTable("LicensesAccessControll");

            builder
                .Property(a => a.Description)
                .HasColumnType("varchar(300)")
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
