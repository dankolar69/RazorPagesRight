using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRecap.InputModels;

namespace RazorPagesRecap.Pages
{
    public class SurveyModel : PageModel
    {
        [BindProperty]
        public SurveyInputModel Input { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("Welcome", new { residence = Input.Residence });
        }


    }
}
