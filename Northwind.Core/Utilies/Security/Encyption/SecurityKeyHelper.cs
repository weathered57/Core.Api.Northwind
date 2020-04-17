using System.Text;
using Microsoft.IdentityModel.Tokens;
namespace Northwind.Core.Utilies.Security.Encyption
{
    public class SecurityKeyHelper
    {
       public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}