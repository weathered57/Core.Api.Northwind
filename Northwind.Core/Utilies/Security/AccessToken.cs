using System;
namespace Northwind.Core.Utilies.Security
{
   public class AccessToken
    {
        public string Token { get; set; }

        public DateTime Expriration { get; set; }
    }
}