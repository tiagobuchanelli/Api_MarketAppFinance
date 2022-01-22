using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class VendaFormaPagamentoConfiguracao : IEntityTypeConfiguration<VendaFormaPagamento>
    {
        public void Configure(EntityTypeBuilder<VendaFormaPagamento> builder)
        {
            builder
               .ToTable("VendaFormasPagamento");

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