using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models
{
    public class VendaViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public int CodigoCliente { get; set; }

        public IEnumerable<SelectListItem> ListaClientes { get; set; }
        public IEnumerable<SelectListItem> ListaProdutos { get; set; }

        public string JsonProdutos { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório..!")]
        public decimal Total { get; set; }

    }
}
