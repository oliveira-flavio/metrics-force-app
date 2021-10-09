using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class Comissao : Entity
    {
        public int IdUsuario { get; private set; }
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        public decimal Valor { get; private set; }
        [Display(Name ="Mês Referência")]
        public DateTime MesReferencia { get; private set; }
        public Vendedor Vendedor { get; private set; }
        public Gerente Gerente { get; private set; }
    }
}
