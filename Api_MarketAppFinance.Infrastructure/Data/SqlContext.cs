using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.EntitiesConfigurators;
using Microsoft.EntityFrameworkCore;

namespace Api_MarketAppFinance.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateLastUpdate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateLastUpdate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateLastUpdate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        public virtual DbSet<User> Usuarios { get; set; }
    }
}