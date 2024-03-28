using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class AddressInfoFormViewModel
{
    [Required(ErrorMessage = "A valid address line is required")]
    [DataType(DataType.Text)]
    [Display(Name = "Address line", Prompt = "Enter address line")]
    public string AddressLine_1 { get; set; } = null!;

    [DataType(DataType.Text)]
    [Display(Name = "Address line 2 (optional)", Prompt = "Enter your second address line")]
    public string? AddressLine_2 { get; set; } = null!;

    [Required(ErrorMessage = "An valid postal code is required")]
    [DataType(DataType.Text)]
    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    public string PostalCode { get; set; } = null!;

    [Required(ErrorMessage = "An valid city is required")]
    [DataType(DataType.Text)]
    [Display(Name = "City", Prompt = "Enter your city")]
    public string City { get; set; } = null!;

}
