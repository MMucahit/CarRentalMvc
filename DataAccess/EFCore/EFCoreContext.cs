using DataAccess.EFCore.Config;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore
{
    public class EFCoreContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public EFCoreContext()
        {

        }
        public EFCoreContext(DbContextOptions<EFCoreContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new ColorConfig());
        }
    }
}
