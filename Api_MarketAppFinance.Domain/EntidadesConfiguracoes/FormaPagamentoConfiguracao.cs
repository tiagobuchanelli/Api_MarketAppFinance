using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class FormaPagamentoConfiguracao : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder
               .ToTable("FormasPagamento");

            builder
                .Property(a => a.Descricao)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder
               .Property(a => a.Abreviacao)
               .HasColumnType("varchar(50)");

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