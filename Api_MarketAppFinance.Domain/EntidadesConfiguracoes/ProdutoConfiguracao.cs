using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class ProdutoConfiguracao : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
               .ToTable("Produtos");

            builder
                .Property(a => a.Descricao)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder
               .Property(a => a.DescricaoVenda)
               .HasColumnType("varchar(300)");

            builder
               .Property(a => a.CodigoBarras)
               .HasColumnType("varchar(30)");

            builder
               .Property(a => a.CodigoIdentificacao)
               .HasColumnType("varchar(100)");

            builder
               .Property(a => a.Observacao)
               .HasColumnType("varchar(500)");

            builder
               .Property(a => a.ObservacaoVenda)
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