using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesRecap.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Text { get; set; }

        public void OnGet(string text)
        {
            Text = text;
        }
    }
}
