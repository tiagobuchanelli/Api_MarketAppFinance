using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class CategoriaConfiguracao : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder
               .ToTable("Categorias");

            builder
                .Property(a => a.Descricao)
                .HasColumnType("varchar(300)")
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