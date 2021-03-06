using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class CidadeConfiguracao : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder
               .ToTable("Cidades");

            builder
                .Property(a => a.Nome)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder
                .Property(a => a.Cep)
                .HasColumnType("varchar(250)");

            builder
                .Property(a => a.Ativo)
                .HasDefaultValue(false)
                .IsRequired();

            builder
               .Property(a => a.SiglaEstado)
               .HasColumnType("varchar(10)");

            builder
                .Property(a => a.CodigoIbge)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.CodigoIbgeEstado)
                .HasColumnType("varchar(50)")
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