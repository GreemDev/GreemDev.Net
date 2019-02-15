using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreemDev.Pages
{
    public class Discord : PageModel
    {
        public void OnGet()
        {
            Response.Redirect("https://discord.greemdev.net", true);
        }
    }
}