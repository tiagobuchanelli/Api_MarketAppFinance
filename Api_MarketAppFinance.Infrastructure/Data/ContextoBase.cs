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
            modelBuilder.ApplyConfiguration(new LicencaDispositivoConfiguracao());
            modelBuilder.ApplyConfiguration(new DispositivoConfiguracao());
            modelBuilder.ApplyConfiguration(new EmpresaConfiguracao());
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

        public DbSet<Usuario> Users { get; set; }
        public DbSet<Cidade> Cities { get; set; }
        public DbSet<Endereco> Adresses { get; set; }
        public DbSet<Licenca> Licenses { get; set; }
        public DbSet<LicencaDispositivo> Devices { get; set; }
        public DbSet<Empresa> Companies { get; set; }
    }
}