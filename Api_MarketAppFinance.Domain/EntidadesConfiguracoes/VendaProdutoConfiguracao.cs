using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class VendaProdutoConfiguracao : IEntityTypeConfiguration<VendaProduto>
    {
        public void Configure(EntityTypeBuilder<VendaProduto> builder)
        {
            builder
               .ToTable("VendaProdutos");

            builder
               .Property(a => a.Observacao)
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