using System.ComponentModel.DataAnnotations;

namespace FitnessFrog.Models;

public class AccountRegisterViewModel
{
    [Required, EmailAddress]
    public string Email { get; set; } = null!;
    [Required, StringLength(100, MinimumLength = 6, ErrorMessage = "The {0} must be at least {2} characters long.")]
    public string Password { get; set; } = null!;
    [Display(Name = "Confirm Password"), Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; } = null!;
}