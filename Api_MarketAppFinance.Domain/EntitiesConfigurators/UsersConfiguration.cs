using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Usuarios");

            builder
                .Property(a => a.Name)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
                .Property<DateTime>("DateLastUpdate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            builder
               .Property<DateTime>("DateCreated")
               .HasColumnType("datetime")
               .HasDefaultValueSql("getdate()")
               .IsRequired();
        }
    }
}