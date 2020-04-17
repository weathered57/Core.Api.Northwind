using System.Text;
namespace Northwind.Core.Utilies.Hasing
{
    public class HashingHelper
    {
       public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            }
        }

        public static bool VeriftyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computeHash.Length; i++)
                {
                    if(computeHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
               
            }

            return true;
        }
    }
}