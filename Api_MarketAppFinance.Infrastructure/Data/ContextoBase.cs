using Api_MarketAppFinance.Domain.Entidades;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.EntitiesConfigurators;
using Microsoft.EntityFrameworkCore;

namespace Api_MarketAppFinance.Data
{
    public class ContextoBase : DbContext
    {
        public ContextoBase()
        {
        }

        public ContextoBase(DbContextOptions<ContextoBase> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=15432;Database=MarketApp;User Id=postgres;Password=joomla11080;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            modelBuilder.ApplyConfiguration(new CidadeConfiguracao());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguracao());
            modelBuilder.ApplyConfiguration(new LicencaConfiguracao());
            modelBuilder.ApplyConfiguration(new LicencaAcessoConfiguracao());
            modelBuilder.ApplyConfiguration(new LicensaDispositivoConfiguracao());
            modelBuilder.ApplyConfiguration(new Domain.EntitiesConfigurators.EmpresaConfiguracao());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguracao());
            modelBuilder.ApplyConfiguration(new SubCategoriaConfiguracao());
            modelBuilder.ApplyConfiguration(new ClassificacaoConfiguracao());
            modelBuilder.ApplyConfiguration(new MarcaConfiguracao());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguracao());
            modelBuilder.ApplyConfiguration(new ImagemProdutoConfiguracao());
            modelBuilder.ApplyConfiguration(new LoteConfiguracao());
            modelBuilder.ApplyConfiguration(new OrigemMovimentacaoProdutosConfiguracao());
            modelBuilder.ApplyConfiguration(new MovimentacaoProdutoConfiguracao());
            modelBuilder.ApplyConfiguration(new MovimentacaoProdutoLoteConfiguracao());
            modelBuilder.ApplyConfiguration(new LogRegistroConfiguracao());
            modelBuilder.ApplyConfiguration(new FornecedorConfiguracao());
            modelBuilder.ApplyConfiguration(new ClienteConfiguracao());
            modelBuilder.ApplyConfiguration(new CarteiraConfiguracao());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguracao());
            modelBuilder.ApplyConfiguration(new VendaConfiguracao());
            modelBuilder.ApplyConfiguration(new VendaProdutoConfiguracao());
            modelBuilder.ApplyConfiguration(new VendaFormaPagamentoConfiguracao());
            modelBuilder.ApplyConfiguration(new VendaParcelaConfiguracao());
            modelBuilder.ApplyConfiguration(new ContaAPagarConfiguracao());
            modelBuilder.ApplyConfiguration(new ContaAPagarParcelaConfiguracao());
            modelBuilder.ApplyConfiguration(new ContaAReceberConfiguracao());
            modelBuilder.ApplyConfiguration(new ContaAReceberParcelaConfiguracao());
            modelBuilder.ApplyConfiguration(new ContaAReceberParcelaBaixaConfiguracao());
            modelBuilder.ApplyConfiguration(new ContaAPagarParcelaBaixaConfiguracao());
            modelBuilder.ApplyConfiguration(new ConfiguracaoEmpresaConfiguracao());
        }

        public override int SaveChanges()
        {
            /*
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("UpdateAt") != null))
            {
                entry.Property("UpdateAt").CurrentValue = DateTime.Now;
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreateAt").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreateAt").IsModified = false;
                }
            }*/
            return base.SaveChanges();
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Licenca> Licensas { get; set; }

        public DbSet<LicencaDispositivo> Dispositivos { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<SubCategoria> SubCategorias { get; set; }

        public DbSet<Classificacao> Classificacao { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ImagemProduto> ImagensProduto { get; set; }

        public DbSet<Lote> Lotes { get; set; }

        public DbSet<OrigemMovimentacaoProduto> OrigemMovimentacaoProdutos { get; set; }

        public DbSet<MovimentacaoProduto> MovimentacaoProdutos { get; set; }

        public DbSet<MovimentacaoProdutoLote> MovimentacaoProdutoLotes { get; set; }

        public DbSet<LogRegistro> LogsRegistros { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Carteira> Carteiras { get; set; }

        public DbSet<FormaPagamento> FormasPagamento { get; set; }

        public DbSet<Venda> Vendas { get; set; }

        public DbSet<VendaProduto> VendaProdutos { get; set; }

        public DbSet<VendaFormaPagamento> VendaFormasPagamento { get; set; }

        public DbSet<VendaParcela> VendaParcelas { get; set; }

        public DbSet<ContaAPagar> ContasAPagar { get; set; }

        public DbSet<ContaAPagarParcela> ContaAPagarParcelas { get; set; }

        public DbSet<ContaAReceber> ContasAReceber { get; set; }

        public DbSet<ContaAReceberParcela> ContaAReceberParcelas { get; set; }

        public DbSet<ContaAReceberParcelaBaixa> ContaAReceberParcelaBaixas { get; set; }

        public DbSet<ContaAPagarParcelaBaixa> ContaAPagarParcelaBaixas { get; set; }

        public DbSet<Domain.Entidades.EmpresaConfiguracao> ConfiguracoesEmpresa { get; set; }
    }
}