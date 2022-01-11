using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class LicencaDispositivoConfiguracao : IEntityTypeConfiguration<LicencaAcesso>
    {
        public void Configure(EntityTypeBuilder<LicencaAcesso> builder)
        {
            builder
               .ToTable("LicencaDispositivos");

            builder
                .Property(a => a.Descricao)
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