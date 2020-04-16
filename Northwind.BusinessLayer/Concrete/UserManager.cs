using Northwind.BusinessLayer.Abstract;
using Northwind.Core.Entities.Concrete;
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
             _userDal.GetClaims(user);
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