using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace BahanKiSadi_backend.Helper    
{
    public class TokenHelper
    {
        public static string GenerateToken(IConfiguration _config)
        {
            var sequrityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credential = new SigningCredentials(sequrityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], null,
                expires: DateTime.Now.AddDays(60),
                signingCredentials:credential
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
