using Entities.Abstract;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public Color(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
        public Color()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
