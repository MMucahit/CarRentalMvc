using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasAlternateKey(c => c.UserId);
            builder.Property(c => c.CompanyName);
            builder.HasData(
                new Customer()
                {
                    UserId = 1,
                    CompanyName = "Huawei",
                },
                new Customer()
                {
                    UserId = 2,
                    CompanyName = "Turkcell",
                },
                new Customer()
                {
                    UserId = 3,
                    CompanyName = "Trendyol",
                }
                );
        }
    }
}
