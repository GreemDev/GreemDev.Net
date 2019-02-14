using System.Threading.Tasks;
using GreemDev.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreemDev.Models {
    public class FeedbackFormModel : PageModel {
        
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            await Webhook.SendAsync(Name, Email, Message);
            return Page();
        }
        
    }
}