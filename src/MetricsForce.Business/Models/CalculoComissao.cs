using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Business.Models
{
    class CalculoComissao
    {
        public decimal ValorRealizado { get; set; }
        public decimal ValorBronze { get; set; }
        public decimal ValorPrata { get; set; }
        public decimal ValorOuro { get; set; }
        public decimal Diamante { get; set; }
        public float PorcentagemComissaoNormal { get; set; }
        public float PorcentagemComissaoBronze { get; set; }
        public float PorcentagemComissaoPrata { get; set; }
        public float PorcentagemComissaoOuro { get; set; }
        public float PorcentagemComissaoDiamante { get; set; }
    }
}
