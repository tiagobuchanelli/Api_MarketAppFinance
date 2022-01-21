using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class ContaAPagarParcelaConfiguracao : IEntityTypeConfiguration<ContaAPagarParcela>
    {
        public void Configure(EntityTypeBuilder<ContaAPagarParcela> builder)
        {
            builder
               .ToTable("ContaAPagarParcelas");

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