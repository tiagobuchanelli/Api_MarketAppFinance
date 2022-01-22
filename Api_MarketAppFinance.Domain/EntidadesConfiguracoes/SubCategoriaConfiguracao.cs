using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class SubCategoriaConfiguracao : IEntityTypeConfiguration<SubCategoria>
    {
        public void Configure(EntityTypeBuilder<SubCategoria> builder)
        {
            builder
               .ToTable("SubCategorias");

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