using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class RegistroVenda : Entity
    {
        [Display(Name = "Código Vendedor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(6, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 6)]
        public string CodigoVendedor { get; set; }
        [Display(Name = "Data da Venda")]
        public DateTime Data { get; set; }
        [Display(Name = "Qtde Itens")]
        public int QuantidadeItens { get; set; }
        [Display(Name = "Valor Total")]
        public decimal ValorVenda { get; set; }
    }
}
