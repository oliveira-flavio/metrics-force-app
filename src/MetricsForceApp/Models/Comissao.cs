using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class Comissao : Entity
    {        
        public decimal Valor { get; set; }
        [Display(Name ="Mês Referência")]
        public DateTime MesReferencia { get; set; }
        public Vendedor Vendedor { get; set; }
        public Gerente Gerente { get; set; }
    }
}
