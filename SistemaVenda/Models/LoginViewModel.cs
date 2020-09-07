using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "informe o {0} !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "informe o {0} !")]
        public string Senha { get; set; }
    }
}
