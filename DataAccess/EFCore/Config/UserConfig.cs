using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id); // Primary Key
            builder.Property(u => u.FirstName);
            builder.Property(u => u.LastName);
            builder.Property(u => u.Email);
            builder.Property(u => u.Password);
            builder.HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Mücahit",
                    LastName = "Nas",
                    Email = "Mücahit.Nas@gmail.com",
                    Password = "Mücahit_Nas",
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Yuşa",
                    LastName = "Akcan",
                    Email = "Yusa.Akcan@gmail.com",
                    Password = "Yusa_Akcan",
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Melih",
                    LastName = "Çiftçi",
                    Email = "Melih.Çiftçi@gmail.com",
                    Password = "Melih_Çiftçi",
                }
                );
        }
    }
}
