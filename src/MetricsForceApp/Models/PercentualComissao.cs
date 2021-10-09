using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class PercentualComissao : Entity
    {
        public int IdComissao { get; private set; }
        [Display(Name = "Porcentagem Base")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public float PorcentagemComissaoBase { get; private set; }
        [Display(Name = "Porcentagem Bronze")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public float PorcentagemComissaoBronze { get; private set; }
        [Display(Name = "Porcentagem Prata")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public float PorcentagemComissaoPrata { get; private set; }
        [Display(Name = "Porcentagem Ouro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public float PorcentagemComissaoOuro { get; private set; }
        [Display(Name = "Porcentagem Diamante")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public float PorcentagemComissaoDiamante { get; private set; }
        public Comissao Comissao { get; private set; }
    }
}
