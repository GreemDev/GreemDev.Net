using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreemDev.Pages
{
    public class Fuckhead : PageModel
    {
        public void OnGet()
        {
            Response.Redirect(
                "https://discordapp.com/oauth2/authorize?client_id=400407128441094144&scope=bot&permissions=8", true);
        }
    }
}