using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class VendaConfiguracao : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder
               .ToTable("Vendas");

            builder
               .Property(a => a.Observacao)
               .HasColumnType("varchar(2000)")
               .IsRequired();

            builder
               .Property(a => a.Ativo)
               .HasDefaultValue(false)
               .IsRequired();

            builder
               .Property(a => a.DataEmissao)
               .HasColumnType("date")
               .IsRequired();

            builder
               .Property(a => a.DataSaida)
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