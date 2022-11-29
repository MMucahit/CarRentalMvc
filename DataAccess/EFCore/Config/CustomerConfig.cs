using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id); //Primary Key
            builder.Property(c => c.UserId);
            builder.Property(c => c.CompanyName);
            builder.HasData(
                new Customer()
                {
                    Id = 1,
                    UserId = 1,
                    CompanyName = "Huawei",
                },
                new Customer()
                {
                    Id = 2,
                    UserId = 2,
                    CompanyName = "Turkcell",
                },
                new Customer()
                {
                    Id = 3,
                    UserId = 3,
                    CompanyName = "Trendyol",
                }
                );
        }
    }
}
