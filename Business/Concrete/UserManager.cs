using Business.AbstractValidator;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcern.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            ValidationTools.Validate(new UserValidator(), user);

            _userDal.Add(user);
            return new SuccessResult(true, "Added!");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(true, "Deleted");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), true, "");
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id), true, "");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(true, "Updated");
        }

        public IDataResult<List<UserDetailDto>> UserDetail()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.UserDetail(), true, "");
        }
    }
}
