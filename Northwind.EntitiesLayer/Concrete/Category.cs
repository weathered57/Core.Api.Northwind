using Northwind.EntitiesLayer.Absract;
namespace Northwind.EntitiesLayer.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}