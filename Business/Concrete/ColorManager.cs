using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(Color color)
        {
            return _colorDal.GetById(color);
        }

        public Color GetById(int id)
        {
            return _colorDal.GetById(id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
