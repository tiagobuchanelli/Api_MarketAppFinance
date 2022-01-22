using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class MovimentacaoProdutoConfiguracao : IEntityTypeConfiguration<MovimentacaoProduto>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoProduto> builder)
        {
            builder
               .ToTable("MovimentacaoProdutos");

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