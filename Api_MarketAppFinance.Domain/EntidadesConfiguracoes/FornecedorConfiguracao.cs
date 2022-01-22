using Api_MarketAppFinance.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_MarketAppFinance.Domain.EntitiesConfigurators
{
    public class FornecedorConfiguracao : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder
                .ToTable("Fornecedores");

            builder
                .Property(a => a.NomeFantasia)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder
                .Property(a => a.RazaoSocial)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder
                .Property(a => a.Ativo)
                .HasDefaultValue(false)
                .IsRequired();

            builder
               .Property(a => a.Telefone1)
               .HasColumnType("varchar(50)");

            builder
               .Property(a => a.Telefone2)
               .HasColumnType("varchar(50)");

            builder
               .Property(a => a.Imagem)
               .HasColumnType("text");

            builder
               .Property(a => a.Rua)
               .HasColumnType("varchar(300)");

            builder
              .Property(a => a.Numero)
              .HasColumnType("varchar(10)");

            builder
              .Property(a => a.Cep)
              .HasColumnType("varchar(20)");

            builder
              .Property(a => a.Letra)
              .HasColumnType("varchar(10)");

            builder
              .Property(a => a.Complemento)
              .HasColumnType("varchar(100)");

            builder
              .Property(a => a.Bairro)
              .HasColumnType("varchar(100)");

            builder
              .Property(a => a.Email)
              .HasColumnType("varchar(250)");

            builder
              .Property(a => a.Observacao)
              .HasColumnType("varchar(500)");

            builder
              .Property(a => a.NumeroDocumento)
              .HasColumnType("varchar(100)");

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