using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class UserDetailDto : IDto
    {
        public UserDetailDto(string firstName, string lastName, string companyName)
        {
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
        }
        public UserDetailDto()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

    }
}
