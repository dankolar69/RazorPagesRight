using System.ComponentModel.DataAnnotations;
using static RazorPagesRecap.Pages.SurveyModel;

namespace RazorPagesRecap.InputModels
{
    public class SurveyInputModel
    {
        [Required(ErrorMessage = "Křestní jméno je vyžadováno.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Příjmení je vyžadováno.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email je vyžadován.")]
        [EmailAddress(ErrorMessage = "Neplatný formát emailu.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Musíte být starší 15 let.")]
        public bool Over15 { get; set; }

        [Required(ErrorMessage = "Vyberte obec.")]
        public string Residence { get; set; }

        [Required(ErrorMessage = "Vyberte pohlaví.")]
        public Gender Gender { get; set; }


        public string? Title { get; set; }


        [Required(ErrorMessage = "Vyprávějte o svém životě je vyžadováno.")]
        [MinLength(30, ErrorMessage = "Vyprávějte o svém životě musí být minimálně 30 znaků.")]
        public string LifeStory { get; set; }
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
