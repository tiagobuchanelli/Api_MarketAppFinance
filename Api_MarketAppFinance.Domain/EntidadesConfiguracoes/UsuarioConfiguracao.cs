using Api_MarketAppFinance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .ToTable("Usuarios");

            builder
                .Property(a => a.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.Sobrenome)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
                .Property(a => a.Email)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
                .Property(a => a.Senha)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(a => a.NumeroDocumento)
                .HasColumnType("varchar(50)")
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