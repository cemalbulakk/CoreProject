using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
}