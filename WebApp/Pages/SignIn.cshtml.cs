using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages;

public class SignInModel : PageModel
{
    public string PageTitle { get; set; } = "Sign In";

    [BindProperty]

    public SignInFormModel Form { get; set; } = new SignInFormModel();


    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            return Page();
        }

        // Sends the form to a userService for confirmation
        // var result = _userService.SignInUser(From);

        return RedirectToPage("/index");
    }
}
