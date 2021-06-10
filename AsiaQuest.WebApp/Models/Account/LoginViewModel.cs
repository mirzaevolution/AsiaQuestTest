using System.ComponentModel.DataAnnotations;

namespace AsiaQuest.WebApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "This field is mandatory")]
        [Display(Name = "Username")]
        [MaxLength(255)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This field is mandatory"),
            MinLength(4, ErrorMessage = "Min char length is 4"),
            DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
