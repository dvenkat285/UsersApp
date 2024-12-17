using System.ComponentModel.DataAnnotations;

namespace UsersApp.ViewModels
{
    public class VerifyEmailViewModel
    {
        [required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
