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
        public DateTime InicioMeta { get; private set; }
        [Display(Name ="Fim Meta")]
        public DateTime FimMeta { get; private set; }
        [Display(Name ="Meta Bronze")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal MetaBronze { get; private set; }
        [Display(Name = "Meta Prata")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal MetaPrata { get; private set; }
        [Display(Name = "Meta Ouro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal MetaOuro { get; private set; }
        [Display(Name = "Meta Diamante")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal MetaDiamante { get; private set; }
        public Gerente Gerente { get; private set; }
        public Vendedor Vendedor { get; private set; }
    }
}
