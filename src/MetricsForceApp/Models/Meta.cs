using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class Meta : Entity
    {
        [Display(Name ="Início da Meta")]
        public DateTime InicioMeta { get; set; }
        [Display(Name ="Fim Meta")]
        public DateTime FimMeta { get; set; }
        [Display(Name ="Meta Mensal")]
        public decimal MetaMes { get; set; }

        public Gerente Gerente { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
