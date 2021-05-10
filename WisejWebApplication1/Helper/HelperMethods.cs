using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;
using AFIT_Cooperative.Models;

namespace AFIT_Cooperative.Helper
{
    public class JwtToken
    {
        private static string key = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b372742" +
            "9090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";
        private static int tokenTime = 60 * 24 * 7;
        private static JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        private static SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

        public static string GenerateToken(object data)
        {
            data = data.ToJSON();
            var header = new JwtHeader(new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256));
            var PayLoad = new JwtPayload
            {
                { "data", data }
            };

            var encodeObj = new JwtSecurityToken(header, PayLoad);
            handler.TokenLifetimeInMinutes = tokenTime;
            return handler.WriteToken(encodeObj);
        }

        public static Member DecodeToken(string token)
        {
            var tokenString = handler.ReadJwtToken(token);
            var m = tokenString.Payload.First().Value.ToString();
            return JsonConvert.DeserializeObject<Member>(m);
        }
    }
}