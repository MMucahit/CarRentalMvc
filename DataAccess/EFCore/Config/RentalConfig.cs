using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.Config
{
    public class RentalConfig : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.HasKey(r => r.Id); // Primary Key
            builder.Property(r => r.CarId);
            builder.Property(r => r.CustomerId);
            builder.Property(r => r.RentDate).HasDefaultValueSql("GETDATE()");
            builder.Property(r => r.ReturnDate).HasDefaultValue(null);
            builder.HasData(
                new Rental()
                {
                    Id = 1,
                    CarId = 1,
                    CustomerId = 1
                },
                new Rental()
                {
                    Id = 2,
                    CarId = 2,
                    CustomerId = 2
                },
                new Rental()
                {
                    Id = 3,
                    CarId = 3,
                    CustomerId = 3
                }
                );
        }
    }
}
