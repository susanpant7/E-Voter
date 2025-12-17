using System.ComponentModel.DataAnnotations;

namespace E_Voter.Application.Security;

public class LoginRequest
{
    [Required]
    public string Username { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;
}