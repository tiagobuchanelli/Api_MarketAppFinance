using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class LicensaDispositivoConfiguracao : IEntityTypeConfiguration<LicencaDispositivo>
    {
        public void Configure(EntityTypeBuilder<LicencaDispositivo> builder)
        {
            builder
               .ToTable("Dispositivos");

            builder
                .Property(a => a.Nome)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder
                .Property(a => a.Chave)
                .HasColumnType("varchar(500)");

            builder
              .Property(a => a.DataCriacao)
              .ValueGeneratedOnAdd()
              .HasDefaultValueSql("now()");

            builder
                .Property(a => a.DataAtualizacao)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("now()")
                .IsRequired();
        }
    }
}