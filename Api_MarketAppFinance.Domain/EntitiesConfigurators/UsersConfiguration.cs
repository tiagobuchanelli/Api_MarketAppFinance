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
                .ToTable("Users");

            builder
                .Property(a => a.Name)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.LastName)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
                .Property(a => a.Email)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
                .Property(a => a.DocumentNumber)
                .HasColumnType("varchar(50)");

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