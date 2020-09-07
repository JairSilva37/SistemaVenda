using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models
{
    public class CategoriaViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public string Descricao { get; set; }
    }
}
