using Northwind.EntitiesLayer.Absract;
namespace Northwind.EntitiesLayer.Dtos
{
    public class UserForOperationClaimDto : IDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}