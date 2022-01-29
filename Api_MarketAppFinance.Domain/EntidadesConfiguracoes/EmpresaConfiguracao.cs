using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class EmpresaConfiguracao : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder
                .ToTable("Empresas");

            builder
                .Property(a => a.NomeFantasia)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder
                .Property(a => a.RazaoSocial)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
               .Property(a => a.NumeroDocumento)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder
                .Property(a => a.Telefone)
                .HasColumnType("varchar(50)");

            builder
                .Property(a => a.Ativo)
                .HasDefaultValue(false)
                .IsRequired();

            builder
               .Property(a => a.Imagem)
               .HasColumnType("text");

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