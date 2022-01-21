using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class ContaAReceberParcelaConfiguracao : IEntityTypeConfiguration<ContaAReceberParcela>
    {
        public void Configure(EntityTypeBuilder<ContaAReceberParcela> builder)
        {
            builder
               .ToTable("ContaAReceberParcelas");

            builder
               .Property(a => a.Observacao)
               .HasColumnType("varchar(2000)")
               .IsRequired();

            builder
               .Property(a => a.DataVencimento)
               .HasColumnType("date")
               .IsRequired();

            builder
               .Property(a => a.DataPagamento)
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