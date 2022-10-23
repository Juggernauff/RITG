using System.ComponentModel.DataAnnotations;

namespace TaskMVC.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указан Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
