namespace DataAccess.Concrete.EntityFramework
{
    public interface IEntityRepository<T>
    {
        T GetById(T entity);
        T GetById(int id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
