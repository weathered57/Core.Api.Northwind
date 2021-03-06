using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Northwind.EntitiesLayer.Concrete;
using Northwind.EntitiesLayer.Dtos;
using Northwind.Core.Extensions;
using Northwind.Core.Utilies.Security.Encyption;

namespace Northwind.Core.Utilies.Security.Jwt
{
        public class JwtHelper : ITokenHelper
        {
            public IConfiguration Configuration { get; }
            private TokenOptions _tokenOptions;
            private DateTime _accessTokenExpiration;

            public JwtHelper(IConfiguration configuration)
            {
                Configuration = configuration;
                _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            }


            public AccessToken CreateToken(User user, List<UserForOperationClaimDto> operationClaims)
            {
                _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
                var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
                var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
                var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
                var JwtSecurityTokenHandler = new JwtSecurityTokenHandler();
                var token = JwtSecurityTokenHandler.WriteToken(jwt);

                return new AccessToken
                {
                    Token = token,
                    Expriration=_accessTokenExpiration
                };
            }

            public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions,User user,SigningCredentials signingCredentials,List<UserForOperationClaimDto> operationClaims)
            {
                var jwt = new JwtSecurityToken(
                    issuer:tokenOptions.Issuer,
                    audience:tokenOptions.Audience,
                    expires:_accessTokenExpiration,
                    notBefore:DateTime.Now,
                    claims:SetClaims(user,operationClaims),
                    signingCredentials:signingCredentials
                    );
                return jwt;
            }

            private IEnumerable<Claim> SetClaims(User user,List<UserForOperationClaimDto> operationClaims)
            {
                var claims = new List<Claim>();
                claims.AddNameIdentifier(user.Id.ToString());
                claims.AddEmail(user.Email);
                claims.AddName($"{user.Firstname} {user.Lastname}");
                claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());
                return claims;
            }
        }
}