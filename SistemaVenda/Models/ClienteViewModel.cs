using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models
{
    public class ClienteViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public string CPF_CNPJ { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public string Celular { get; set; }
    }
}
