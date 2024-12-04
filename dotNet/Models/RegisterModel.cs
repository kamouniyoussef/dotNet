using System.ComponentModel.DataAnnotations;

namespace dotNet.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Les mots de passe ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

}
