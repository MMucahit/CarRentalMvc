using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.Config
{
    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(b => b.Id); // Primary Key
            builder.Property(b => b.Name);
            builder.HasData(
                new Color()
                {
                    Id = 1,
                    Name = "Black",
                },
                new Color()
                {
                    Id = 2,
                    Name = "Grey",
                },
                new Color()
                {
                    Id = 3,
                    Name = "White",
                }
                );
        }
    }
}
