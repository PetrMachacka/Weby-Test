using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRecap.InputModels;

namespace RazorPagesRecap.Pages
{
    public class SurveyModel : PageModel
    {
        [BindProperty]
        public Validation Validace { get; set; } = new Validation();
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                string selectedValue = Validace.Home.ToString();

                Console.WriteLine("Valid form");
                return RedirectToPage("/Welcome", new { text = selectedValue });
                }

            return Page();
        }
    }
}
