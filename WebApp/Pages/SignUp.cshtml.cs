using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages;

public class SignUpModel : PageModel
{
    public string PageTitle { get; set; } = "Sign Up";

    [BindProperty]

    public SignUpFormModel Form { get; set; } = new SignUpFormModel();


    // Loading up the form when going into the sign up webpage
    public void OnGet()
    {
    }


    // Sends the form to a userService for registration
    // var result = _userService.CreateUser(From);
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("/index");
    }
}
