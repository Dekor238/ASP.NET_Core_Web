using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TS.Repositories.Interfaces;

namespace TS.Services
{
    public class UserService : IUserService
    {
        private readonly IUser _user;

        public UserService(IUser user)
        {
            _user = user;
        }

        public const string SecretCode = "THIS IS SOME VERY SECRET STRING!!! Im blue da ba dee da ba di da ba dee da ba di da d ba dee da ba di da ba dee";
        public string Authenticate(string user, string password) {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                return string.Empty;
            }
            int i = 0;
            var getUser = _user.GetUser(user, password);
            if (getUser != null)
            {
                i++;
                if (string.CompareOrdinal(getUser.login, user) == 0 && string.CompareOrdinal(getUser.passwd, password) == 0)
                {
                    return GenerateJwtToken(i);
                } 
            }
            return string.Empty;
        }
        
        private string GenerateJwtToken(int id)
        {
            JwtSecurityTokenHandler tokenHandler = new
                JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(SecretCode);
            SecurityTokenDescriptor tokenDescriptor = new
                SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(15),
                    SigningCredentials = new SigningCredentials(new
                        SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}