using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.EntitiesConfigurators;
using Microsoft.EntityFrameworkCore;

namespace Api_MarketAppFinance.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=15432;Database=marketapp;User Id=postgres;Password=joomla11080;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new LicenseConfiguration());
            modelBuilder.ApplyConfiguration(new LicensesAccessControllConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
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

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}