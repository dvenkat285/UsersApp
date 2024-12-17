using System.ComponentModel.DataAnnotations;

namespace UsersApp.ViewModels
{
    public class RegisterViewModel
    {
        [required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }
        [required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
        [required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password doesnot match.")]
        [Display(Name = "New  Password")]
        public string Password { get; set; }
        [required(ErrorMessage = "ConfirmPassword is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm  Password")]
        public string ConfirmPassword { get; set; }
    }
}
