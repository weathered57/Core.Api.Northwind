using Northwind.EntitiesLayer.Dtos;
using Northwind.Core.Utilies.Results;
using Northwind.Core.Utilies.Security;
using Northwind.EntitiesLayer.Concrete;
namespace Northwind.BusinessLayer.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto,string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}