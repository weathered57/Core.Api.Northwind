using Northwind.EntitiesLayer.Absract;
namespace Northwind.EntitiesLayer.Concrete
{
    public class UserOperationClaim : IEntity
    {
         public int Id { get; set; }
        public int UserId { get; set; }
        public int OpearationClaimId { get; set; }
    }
}