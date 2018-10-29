using DevFramework.Core.Entities;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Role :IEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}
