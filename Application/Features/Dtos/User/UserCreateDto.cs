namespace Application.Features.Dtos.User;

public class UserCreateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public virtual string Email { get; set; }
    public virtual string Password { get; set; }
    public virtual string PhoneNumber { get; set; }
    public virtual bool TwoFactorEnabled { get; set; }
}