using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "DrivingLicense")]
        public string DrivingLicense { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}