using Northwind.EntitiesLayer.Absract;
namespace Northwind.EntitiesLayer.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}