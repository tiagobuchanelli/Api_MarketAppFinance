using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder
                .ToTable("Companies");

            builder
                .Property(a => a.Name)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder
                .Property(a => a.ShortName)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
                .Property(a => a.Phone)
                .HasColumnType("varchar(50)");

            builder
                .Property(a => a.IsActive)
                .HasDefaultValue(false)
                .IsRequired();

            builder
               .Property(a => a.Image)
               .HasColumnType("text");

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