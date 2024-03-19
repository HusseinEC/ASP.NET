using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class SignInFormModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email", Prompt = "Enter your email")]
    [Required(ErrorMessage = "Invalid email address")]

    public string Email { get; set; } = null!;


    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Invalid Password")]

    public string Password { get; set; } = null!;


    [Display(Name = "Remember Me")]

    public bool RememberMe { get; set; } = false;
}
