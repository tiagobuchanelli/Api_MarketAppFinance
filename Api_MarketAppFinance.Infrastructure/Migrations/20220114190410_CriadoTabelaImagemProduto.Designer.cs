﻿// <auto-generated />
using System;
using Api_MarketAppFinance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api_MarketAppFinance.Infrastructure.Migrations
{
    [DbContext(typeof(ContextoBase))]
    [Migration("20220114190410_CriadoTabelaImagemProduto")]
    partial class CriadoTabelaImagemProduto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Classificacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Classificacao", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.ImagemProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ImagensProduto", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Marcas", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AliquotaIcmsDentroUf")
                        .HasColumnType("numeric");

                    b.Property<decimal>("AliquotaIpi")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Altura")
                        .HasColumnType("numeric");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("integer");

                    b.Property<int>("ClassificacaoId")
                        .HasColumnType("integer");

                    b.Property<string>("CodigoBarras")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("CodigoIdentificacao")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("ControlaEstoqueLote")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("DescricaoVenda")
                        .HasColumnType("varchar(300)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Espessura")
                        .HasColumnType("numeric");

                    b.Property<decimal>("EstoqueMinimo")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Largura")
                        .HasColumnType("numeric");

                    b.Property<int>("MarcaId")
                        .HasColumnType("integer");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("ObservacaoVenda")
                        .HasColumnType("varchar(500)");

                    b.Property<decimal>("PercentualDesconto")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PercentualLucro")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PesoBruto")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PesoLiquido")
                        .HasColumnType("numeric");

                    b.Property<int>("SubCategoriaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<decimal>("ValorCusto")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorMinimoVenda")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ClassificacaoId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("SubCategoriaId");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.SubCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("SubCategorias", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("CdIbge")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CdIbgeEstado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("SiglaEstado")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.ToTable("Cidades", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Imagem")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("NomeCurto")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Empresas", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .HasColumnType("text");

                    b.Property<int>("CidadeId")
                        .HasColumnType("integer");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Licenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Chave")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("date");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int>("MaxAcesso")
                        .HasColumnType("integer");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Licencas", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.LicencaAcesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<int>("DispositivoId")
                        .HasColumnType("integer");

                    b.Property<int>("LicencaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.HasIndex("DispositivoId");

                    b.HasIndex("LicencaId");

                    b.ToTable("LicencaDispositivos", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.LicencaDispositivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Chave")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Dispositivos", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Imagem")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Categoria", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Classificacao", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.ImagemProduto", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Marca", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Produto", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entidades.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_MarketAppFinance.Domain.Entidades.Classificacao", "Classificacao")
                        .WithMany()
                        .HasForeignKey("ClassificacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_MarketAppFinance.Domain.Entidades.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_MarketAppFinance.Domain.Entidades.SubCategoria", "SubCategoria")
                        .WithMany()
                        .HasForeignKey("SubCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Classificacao");

                    b.Navigation("Empresa");

                    b.Navigation("Marca");

                    b.Navigation("SubCategoria");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.SubCategoria", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entidades.Categoria", "Categoria")
                        .WithMany("SubCategorias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Empresa", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Adresses")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Licenca", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Empresa", "Empresa")
                        .WithMany("Licenses")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.LicencaAcesso", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entities.LicencaDispositivo", "Dispositivo")
                        .WithMany()
                        .HasForeignKey("DispositivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Licenca", "Licenca")
                        .WithMany()
                        .HasForeignKey("LicencaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dispositivo");

                    b.Navigation("Licenca");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.LicencaDispositivo", b =>
                {
                    b.HasOne("Api_MarketAppFinance.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Devices")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entidades.Categoria", b =>
                {
                    b.Navigation("SubCategorias");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Empresa", b =>
                {
                    b.Navigation("Licenses");
                });

            modelBuilder.Entity("Api_MarketAppFinance.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Adresses");

                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
