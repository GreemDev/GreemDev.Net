using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreemDev.Pages
{
    public class Zalgo : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}