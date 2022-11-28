using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.Config
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.Id); // Primary Key
            builder.Property(c => c.BrandId);
            builder.Property(c => c.ColorId);
            builder.Property(c => c.ModelYear);
            builder.Property(c => c.DailyPrice);
            builder.Property(c => c.Description);
            builder.HasData(
                new Car()
                {
                    Id = 1,
                    BrandId = 1,
                    ColorId = 1,
                    ModelYear = 2022,
                    DailyPrice = 1_000_000,
                    Description = "..."
                },
                new Car()
                {
                    Id = 2,
                    BrandId = 2,
                    ColorId = 1,
                    ModelYear = 2004,
                    DailyPrice = 220_000,
                    Description = "..."
                },
                new Car()
                {
                    Id = 3,
                    BrandId = 1,
                    ColorId = 2,
                    ModelYear = 1995,
                    DailyPrice = 95_000,
                    Description = "..."
                }
                );
        }
    }
}
