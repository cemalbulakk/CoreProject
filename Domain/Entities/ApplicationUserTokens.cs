using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class ApplicationUserTokens : IdentityUserToken<string>
{
    public DateTime ExpireDate { get; set; }
}