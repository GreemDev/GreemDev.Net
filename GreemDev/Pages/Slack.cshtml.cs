using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreemDev.Pages
{
    public class Slack : PageModel
    {
        public void OnGet()
        {
            Response.Redirect(
                "https://join.slack.com/t/greem-code/shared_invite/enQtMzk5MjI1MDM5Mzk3LTUxOTMwNDUxYWYwNGQ1N2Q5ZWQ1OWIzZDQ2OTNlMDNjMWVhNDg2MWU3YWQ5NTZjODY4M2I1NGUxZGViM2IwMDY",
                true);
        }
    }
}