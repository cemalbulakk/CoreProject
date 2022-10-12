namespace Application.Features.Dtos.Auth;

public class TokenApiModel
{
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
}