using Business.AbstractValidator;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcern.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }


        public IResult Add(Rental rental)
        {
            ValidationTools.Validate(new RentalValidator(), rental);

            _rentalDal.Add(rental);
            return new SuccessResult(true, "Added!");
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(true, "Delete");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), true, "");
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id), true, "");
        }

        public IDataResult<List<Rental>> RentACar()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.RentACar(), true, "");
        }

        public IDataResult<List<RentalDetailDto>> RentalDetail()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.RentalDetail(), true, "");
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(true, "Update");
        }
    }
}
