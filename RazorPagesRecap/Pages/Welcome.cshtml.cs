using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesRecap.Pages
{
    public class WelcomeModel : PageModel
    {
        [FromRoute]
        public string Residence { get; set; }

        public void OnGet()
        {
        }
    }

    public enum Gender
    {
        [Display(Name = "Žena")]
        Female,

        [Display(Name = "Muž")]
        Male,

        [Display(Name = "Bojová helikoptéra")]
        AttackHelicopter,

        [Display(Name = "Jiná možnost")]
        Other
    }
}
