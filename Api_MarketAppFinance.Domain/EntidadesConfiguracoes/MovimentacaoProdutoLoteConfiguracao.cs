using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class MovimentacaoProdutoLoteConfiguracao : IEntityTypeConfiguration<MovimentacaoProdutoLote>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoProdutoLote> builder)
        {
            builder
               .ToTable("MovimentacaoProdutoLotes");

            builder
               .Property(a => a.DataLancamento)
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