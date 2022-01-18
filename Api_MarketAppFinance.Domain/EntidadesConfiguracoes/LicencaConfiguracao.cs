using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class LicencaConfiguracao : IEntityTypeConfiguration<Licenca>
    {
        public void Configure(EntityTypeBuilder<Licenca> builder)
        {
            builder
               .ToTable("Licencas");

            builder
                .Property(a => a.Descricao)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder
                .Property(a => a.Tipo)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(a => a.Chave)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder
                .Property(a => a.DataExpiracao)
                .HasColumnType("date")
                .IsRequired();

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