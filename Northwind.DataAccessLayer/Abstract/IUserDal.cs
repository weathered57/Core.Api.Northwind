using Northwind.EntitiesLayer.Concrete;
using Northwind.EntitiesLayer.Dtos;
using System.Collections.Generic;
using Northwind.Core.DataAccess;


namespace Northwind.DataAccessLayer.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserForOperationClaimDto> GetClaims(User user);

    }
}