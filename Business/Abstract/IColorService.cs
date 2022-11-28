using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        Color GetById(int id);
        List<Color> GetAll();
        void Add(Color brand);
        void Update(Color brand);
        void Delete(Color brand);
    }
}
