using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public RentalDetailDto(string firstName, string lastName, string companyName, string brand, int modelYear)
        {
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            Brand = brand;
            ModelYear = modelYear;
        }
        public RentalDetailDto()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Brand { get; set; }
        public int ModelYear { get; set; }

    }
}
