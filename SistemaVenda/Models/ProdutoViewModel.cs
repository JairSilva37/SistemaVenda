using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models
{
    public class ProdutoViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public double Quantidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        [Range(0.1, Double.PositiveInfinity)]
        public decimal? Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public int? CodigoCategoria { get; set; }
        public IEnumerable<SelectListItem> ListaCategorias { get; set; }
    }
}
