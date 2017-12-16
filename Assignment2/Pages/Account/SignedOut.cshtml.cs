using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2.Pages.Account
{
	public class SignedOutModel : PageModel
	{
		public IActionResult OnGet()
		{
			if (User.Identity.IsAuthenticated)
			{
				// Redirect to home page if the user is authenticated.
				return RedirectToPage("/Index");
			}

			return Page();
		}
	}
}