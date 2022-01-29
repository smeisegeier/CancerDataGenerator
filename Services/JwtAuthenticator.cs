using JWT.Algorithms;
using JWT.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Rki.CancerDataGenerator.Services
{
    public class JwtAuthenticator : IJwtAuthenticator
    {
        // is passed as ref -> must be a field, no property
        private List<User> Users = new List<User>();
        private IConfiguration _config { get; }
        private string _jwtTokenPasswd => _config.GetValue<string>("JwtTokenPw");

        public JwtAuthenticator(IConfiguration configuration)
        {
            _config = configuration;
            Users = User.GetDefaultValues();

            User.AddItemToList(ref Users,
                new User("user3", "pass3", new string[] { "" })
                );
        }

        public string IsUserAuthenticated(string username, string passwd)
        {
            if (!Users.Any(x => x.Username == username && x.Password == passwd))
            {
                return null;
            }

            var currentUser = Users.Where(x => x.Username == username).First();
            var token = JwtBuilder.Create()
                      .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                      .WithSecret(_jwtTokenPasswd)
                      .Id(currentUser.Id)
                      .IssuedAt(DateTimeOffset.UtcNow.ToUnixTimeSeconds())
                      .ExpirationTime(DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .Issuer("dexterDSD")  // insert app url here
                      .Subject(currentUser.Username)
                      .AddClaim("roles", currentUser.Roles)
                      .Encode();
            
            return token;
        }

        public UserJwt DecodeToken(string token)
        {
            var json = JwtBuilder.Create()
                     .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                     .WithSecret(_jwtTokenPasswd)
                     .MustVerifySignature()
                     .Decode(token);
            var userJwt = Helper.StaticHelper.FromJson<UserJwt>(json);
            return userJwt;
        }

        public struct UserJwt
        {
            // must match claims
            public string jti { get; set; }
            public string iat { get; set; }
            public string exp { get; set; }
            public string iss { get; set; }
            public string sub { get; set; }
            public string[] roles { get; set; }
        }

    }
}
