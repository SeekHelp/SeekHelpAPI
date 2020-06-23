using System.ComponentModel.DataAnnotations;

namespace SeekHelpServer.Models
{
    public class RegisterStudentModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        
        [Required]
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }
    }
}