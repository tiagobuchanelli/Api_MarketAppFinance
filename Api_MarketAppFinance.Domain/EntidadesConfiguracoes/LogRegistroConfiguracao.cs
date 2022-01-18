using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class LogRegistroConfiguracao : IEntityTypeConfiguration<LogRegistro>
    {
        public void Configure(EntityTypeBuilder<LogRegistro> builder)
        {
            builder
               .ToTable("LogsRegistros");

            builder
                .Property(a => a.Tabela)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder
                .Property(a => a.ValorAnterior)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder
                .Property(a => a.ValorAtual)
                .HasColumnType("varchar(500)")
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