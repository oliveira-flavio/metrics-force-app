using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class PercentualComissao : Entity
    {       
        [Display(Name = "Porcentagem Base")]
        public float PorcentagemComissaoBase { get; set; }
        [Display(Name = "Porcentagem Bronze")]
        public float PorcentagemComissaoBronze { get; set; }
        [Display(Name = "Porcentagem Prata")]
        public float PorcentagemComissaoPrata { get; set; }
        [Display(Name = "Porcentagem Ouro")]
        public float PorcentagemComissaoOuro { get; set; }
        [Display(Name = "Porcentagem Diamante")]
        public float PorcentagemComissaoDiamante { get; set; }
        public Comissao Comissao { get; set; }
    }
}
