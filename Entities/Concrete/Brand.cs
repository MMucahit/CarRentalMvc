using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public Brand(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
        public Brand()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
