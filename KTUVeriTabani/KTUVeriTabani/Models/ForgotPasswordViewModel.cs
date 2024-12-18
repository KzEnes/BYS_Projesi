using System.ComponentModel.DataAnnotations;

namespace KTUVeriTabani.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
