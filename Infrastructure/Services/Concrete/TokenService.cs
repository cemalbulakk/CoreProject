using Application.Services.Interfaces;
using Common.Dtos;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Services.Concrete;

public class TokenService : ITokenService
{
    private readonly IApplicationUserTokensService _userTokensService;
    private readonly IConfiguration _config;

    public TokenService(IConfiguration config, IApplicationUserTokensService userTokensService)
    {
        _config = config;
        _userTokensService = userTokensService;
    }

    /// <summary>
    /// Kullanıcı üzerinde tanımlı tokenı döner;Token yoksa oluşturur. Expire olmuşsa update eder.
    /// </summary>
    /// <returns></returns>
    public async Task<ApplicationUserTokens?> GetToken(ApplicationUser applicationUser)
    {
        ApplicationUserTokens? userTokens;
        TokenInfo tokenInfo;

        var existUserTokens = _userTokensService.Count(x => x.UserId.Equals(applicationUser.Id));

        //Kullanıcıya ait önceden oluşturulmuş bir token var mı kontrol edilir.
        if (existUserTokens > 0)
        {
            //İlgili token bilgileri bulunur.
            userTokens = await _userTokensService.GetAsync(x => x.UserId.Equals(applicationUser.Id));

            //Expire olmuş ise yeni token oluşturup günceller.
            if (userTokens == null || userTokens.ExpireDate > DateTime.Now) return userTokens;
            //Create new token
            tokenInfo = GenerateToken(applicationUser);

            userTokens.ExpireDate = tokenInfo.ExpireDate;
            userTokens.Value = tokenInfo.Token;

            await _userTokensService.UpdateAsync(userTokens);
        }
        else
        {
            //Create new token
            tokenInfo = GenerateToken(applicationUser);

            userTokens = new ApplicationUserTokens
            {
                UserId = applicationUser.Id,
                LoginProvider = "SystemAPI",
                Name = applicationUser.FirstName + " " + applicationUser.LastName,
                ExpireDate = tokenInfo.ExpireDate,
                Value = tokenInfo.Token
            };

            await _userTokensService.AddAsync(userTokens);
        }

        //_context.SaveChangesAsync();
        return userTokens;
    }

    /// <summary>
    /// Kullanıcıya ait tokenı siler.
    /// </summary>
    /// <returns></returns>
    public async Task<bool> DeleteToken(ApplicationUser applicationUser)
    {
        var ret = true;

        try
        {
            //Kullanıcıya ait önceden oluşturulmuş bir token var mı kontrol edilir.
            if (_userTokensService.Count(x => x.UserId.Equals(applicationUser.Id)) > 0)
            {
                var userTokens = await _userTokensService.GetAsync(x => x.UserId == applicationUser.Id) ?? throw new InvalidOperationException();

                await _userTokensService.DeleteAsync(userTokens);
            }
        }
        catch (Exception)
        {
            ret = false;
        }

        return ret;
    }

    /// <summary>
    /// Yeni token oluşturur.
    /// </summary>
    /// <returns></returns>
    private TokenInfo GenerateToken(ApplicationUser applicationUser)
    {
        //var expireDate = DateTime.Now.AddSeconds(50);
        //var tokenHandler = new JwtSecurityTokenHandler();
        //var key = Encoding.ASCII.GetBytes(_config["Application:Secret"]);

        //var tokenDescriptor = new SecurityTokenDescriptor
        //{
        //    Audience = _config["Application:Audience"],
        //    Issuer = _config["Application:Issuer"],
        //    Subject = new ClaimsIdentity(new[]
        //    {
        //            //Claim tanımları yapılır. Burada en önemlisi Id ve emaildir.
        //            //Id üzerinden, aktif kullanıcıyı buluyor olacağız.
        //            new Claim(ClaimTypes.NameIdentifier, applicationUser.Id),
        //            new Claim(ClaimTypes.Name, applicationUser.FirstName + " " +applicationUser.LastName),
        //            new Claim(ClaimTypes.Email, applicationUser.Email)
        //    }),

        //    //ExpireDate
        //    Expires = expireDate,

        //    //Şifreleme türünü belirtiyoruz: HmacSha256Signature
        //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //};

        //var token = tokenHandler.CreateToken(tokenDescriptor);
        //var tokenString = tokenHandler.WriteToken(token);

        var issuer = _config["Jwt:Issuer"];
        var audience = _config["Jwt:Audience"];
        var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, applicationUser.UserName),
                new Claim(JwtRegisteredClaimNames.Email, applicationUser.Email),
                new Claim(JwtRegisteredClaimNames.Jti,
                    Guid.NewGuid().ToString())
            }),
            Expires = DateTime.UtcNow.AddMinutes(5),
            Issuer = issuer,
            Audience = audience,
            SigningCredentials = new SigningCredentials
            (new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature)
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var jwtToken = tokenHandler.WriteToken(token);
        var stringToken = tokenHandler.WriteToken(token);

        var tokenInfo = new TokenInfo
        {
            Token = stringToken,
            ExpireDate = token.ValidTo
        };

        return tokenInfo;
    }
}