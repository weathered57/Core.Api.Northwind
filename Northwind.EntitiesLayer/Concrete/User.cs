using Northwind.EntitiesLayer.Absract;
namespace Northwind.EntitiesLayer.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
         public string Firstaname { get; set; }
         public string Lastname { get; set; }
         public string Email { get; set; }
         public byte[] PasswordSalt { get; set; }
         public byte[] PasswordHash { get; set; }
         public bool Status { get; set; }
    }
}