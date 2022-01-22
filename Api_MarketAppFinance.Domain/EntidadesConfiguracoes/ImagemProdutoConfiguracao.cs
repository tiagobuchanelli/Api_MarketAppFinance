using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class ImagemProdutoConfiguracao : IEntityTypeConfiguration<ImagemProduto>
    {
        public void Configure(EntityTypeBuilder<ImagemProduto> builder)
        {
            builder
               .ToTable("ImagensProduto");

            builder
                .Property(a => a.Url)
                .HasColumnType("text")
                .IsRequired();

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