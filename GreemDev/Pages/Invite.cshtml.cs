using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreemDev.Pages
{
    public class Invite : PageModel
    {
        public void OnGet()
        {
            Response.Redirect(
                "https://discordapp.com/oauth2/authorize?client_id=320942091049893888&scope=bot&permissions=8", true);
        }
    }
}