using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public Customer(int ıd, int userId, string companyName)
        {
            Id = ıd;
            UserId = userId;
            CompanyName = companyName;
        }
        public Customer()
        {

        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
