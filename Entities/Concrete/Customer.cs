using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public Customer(int userId, string companyName)
        {
            UserId = userId;
            CompanyName = companyName;
        }
        public Customer()
        {

        }

        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
