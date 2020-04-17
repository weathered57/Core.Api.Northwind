using System.Collections.Generic;
using Northwind.EntitiesLayer.Concrete;
using Northwind.EntitiesLayer.Dtos;
namespace Northwind.Core.Utilies.Security
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user,List<UserForOperationClaimDto> claims);
    }
}