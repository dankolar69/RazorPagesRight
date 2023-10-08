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
        [Display(Name = "�ena")]
        Female,

        [Display(Name = "Mu�")]
        Male,

        [Display(Name = "Bojov� helikopt�ra")]
        AttackHelicopter,

        [Display(Name = "Jin� mo�nost")]
        Other
    }
}
