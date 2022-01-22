using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class LoteConfiguracao : IEntityTypeConfiguration<Lote>
    {
        public void Configure(EntityTypeBuilder<Lote> builder)
        {
            builder
               .ToTable("Lotes");

            builder
                .Property(a => a.Descricao)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder
               .Property(a => a.Ativo)
               .HasDefaultValue(false)
               .IsRequired();

            builder
                .Property(a => a.DataFabricacao)
                .HasColumnType("date");

            builder
                .Property(a => a.DataVencimento)
                .HasColumnType("date");

            builder
                .Property(a => a.Observacao)
                .HasColumnType("varchar(500)");

            builder
                .Property(a => a.NumeroLote)
                .HasColumnType("varchar(500)");

            builder
                .Property(a => a.NumeroEmbalagem)
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