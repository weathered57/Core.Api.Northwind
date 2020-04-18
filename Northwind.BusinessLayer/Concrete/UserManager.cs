using Northwind.BusinessLayer.Abstract;
using Northwind.EntitiesLayer.Concrete;
using Northwind.EntitiesLayer.Dtos;
using System.Collections.Generic;
using Northwind.DataAccessLayer.Abstract;
namespace Northwind.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
             _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<UserForOperationClaimDto> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

   
    }
}