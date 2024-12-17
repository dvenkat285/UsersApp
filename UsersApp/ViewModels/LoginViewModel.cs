using System.ComponentModel.DataAnnotations;

namespace UsersApp.ViewModels
{
    public class LoginViewModel
    {
        [required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string  Email { get; set; }

        [required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember me?")]
        public bool RememberMe { get; set; }
    }
}
