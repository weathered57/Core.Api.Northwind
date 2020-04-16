using Northwind.EntitiesLayer.Concrete;
using Northwind.EntitiesLayer.Dtos;
using System.Collections.Generic;
namespace Northwind.BusinessLayer.Abstract
{
    public interface IUserService
    {
        List<UserForOperationClaimDto> GetClaims(User user);

        void Add(User user);

        User GetByMail(string email);
    }
}