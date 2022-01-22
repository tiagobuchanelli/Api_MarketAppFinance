using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class ContaAReceberParcelaBaixaConfiguracao : IEntityTypeConfiguration<ContaAReceberParcelaBaixa>
    {
        public void Configure(EntityTypeBuilder<ContaAReceberParcelaBaixa> builder)
        {
            builder
               .ToTable("ContaAReceberParcelaBaixas");

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