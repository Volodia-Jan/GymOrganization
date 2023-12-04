using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using GymOrganization.Domain.ServiceContracts;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace GymOrganization.Domain.Services;

public class JwtService : IJwtService
{
    private readonly IConfiguration _configuration;

    public JwtService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateJwt(Guid userId, string email, string roleName)
    {
        var jwt = _configuration.GetSection("JWT");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt["Key"]));
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, userId.ToString()),
            new(ClaimTypes.Name, email),
            new(ClaimTypes.Role, roleName)
        };
        
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(7),
            SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature)
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}