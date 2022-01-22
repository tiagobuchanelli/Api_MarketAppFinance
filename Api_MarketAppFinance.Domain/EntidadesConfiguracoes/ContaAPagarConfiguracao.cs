using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class ContaAPagarConfiguracao : IEntityTypeConfiguration<ContaAPagar>
    {
        public void Configure(EntityTypeBuilder<ContaAPagar> builder)
        {
            builder
               .ToTable("ContasAPagar");

            builder
               .Property(a => a.Observacao)
               .HasColumnType("varchar(500)");

            builder
               .Property(a => a.Ativo)
               .HasDefaultValue(false)
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