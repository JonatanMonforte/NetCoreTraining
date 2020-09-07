using AT.Model.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AT.DataAccess.Data
{
    public class ATDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public ATDbContext()
        {
            
        }

        public ATDbContext(DbContextOptions Options, IConfiguration Configuration) : base(Options)
        {
            configuration = Configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        /* Tables */
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }

    }
}