using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public Rental(int ıd, int carId, int customerId, DateTime rentDate, DateTime returnDate)
        {
            Id = ıd;
            CarId = carId;
            CustomerId = customerId;
            RentDate = rentDate;
            ReturnDate = returnDate;
        }
        public Rental()
        {

        }
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
