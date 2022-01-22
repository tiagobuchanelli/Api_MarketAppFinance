using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class ContaAPagarParcelaBaixaConfiguracao : IEntityTypeConfiguration<ContaAPagarParcelaBaixa>
    {
        public void Configure(EntityTypeBuilder<ContaAPagarParcelaBaixa> builder)
        {
            builder
               .ToTable("ContaAPagarParcelaBaixas");

            builder
               .Property(a => a.Observacao)
               .HasColumnType("varchar(500)");

            builder
              .Property(a => a.Observacao)
              .HasColumnType("varchar(500)");

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