using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class ConfiguracaoEmpresaConfiguracao : IEntityTypeConfiguration<Entidades.EmpresaConfiguracao>
    {
        public void Configure(EntityTypeBuilder<Entidades.EmpresaConfiguracao> builder)
        {
            builder
               .ToTable("EmpresaConfiguracoes");

            builder
               .Property(a => a.UsaControleLotes)
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