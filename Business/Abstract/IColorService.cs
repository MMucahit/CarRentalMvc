using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.AbstractValidator
{
    public interface IColorService
    {
        IDataResult<Color> GetById(int id);
        IDataResult<List<Color>> GetAll();
        IResult Add(Color brand);
        IResult Update(Color brand);
        IResult Delete(Color brand);
    }
}
