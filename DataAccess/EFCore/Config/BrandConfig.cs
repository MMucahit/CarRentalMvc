using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.Config
{
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id); // Primary Key
            builder.Property(b => b.Name);
            builder.HasData(
                new Brand()
                {
                    Id = 1,
                    Name = "BMW",
                },
                new Brand()
                {
                    Id = 2,
                    Name = "Toyota",
                },
                new Brand()
                {
                    Id = 3,
                    Name = "Mercedes-Benz",
                }
                );
        }
    }
}
