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
        [Display(Name ="Meta Bronze")]
        public decimal MetaBronze { get; set; }
        [Display(Name = "Meta Prata")]
        public decimal MetaPrata { get; set; }
        [Display(Name = "Meta Ouro")]
        public decimal MetaOuro { get; set; }
        [Display(Name = "Meta Diamante")]
        public decimal MetaDiamante { get; set; }
        public Gerente Gerente { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
