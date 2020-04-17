using Northwind.Core.DataAccess.EntitiyFramework;
using Northwind.EntitiesLayer.Concrete;
using Northwind.EntitiesLayer.Dtos;
using Northwind.DataAccessLayer.Concrete.EntitityFramework.Context;
using Northwind.DataAccessLayer.Abstract;
using System.Linq;
using System.Collections.Generic;
namespace Northwind.DataAccessLayer.Concrete.EntitityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserForOperationClaimDto> GetClaims(User user)
        {
             using (var context = new NorthwindContext())
            {
           var result = from oc in context.OperationClaims
                         join uoc in context.UserOperationClaims
                         on oc.Id equals uoc.OpearationClaimId
                         where uoc.UserId == user.Id
                         select new UserForOperationClaimDto
                         {
                             Id = oc.Id,
                             Name = oc.Name
                         };
                         return result.ToList();
            }
           
            
        }
    }
}