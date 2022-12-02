using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.AbstractValidator
{
    public interface IUserService
    {
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();
        IDataResult<List<UserDetailDto>> UserDetail();
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
