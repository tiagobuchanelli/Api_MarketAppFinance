using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
               .ToTable("Cities");

            builder
                .Property(a => a.Name)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder
                .Property(a => a.ZipCode)
                .HasColumnType("varchar(250)");

            builder
                .Property(a => a.IsActive)
                .HasDefaultValue(false)
                .IsRequired();

            builder
               .Property(a => a.StateSymbol)
               .HasColumnType("varchar(10)");

            builder
                .Property(a => a.CodeIgbe)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.StateCodeIgbe)
                .HasColumnType("varchar(50)")
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