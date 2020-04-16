using Northwind.Core.DataAccess;
using Northwind.Core.Entities.Concrete;
using System.Collections.Generic;

namespace Northwind.DataAccessLayer.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserForOperationClaimDto> GetClaims(User user);

    }
}