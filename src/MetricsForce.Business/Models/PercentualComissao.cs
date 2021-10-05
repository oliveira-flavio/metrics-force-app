﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Business.Models
{
    public class PercentualComissao
    {
        public float PorcentagemComissaoBase { get; private set; }
        public float PorcentagemComissaoBronze { get; private set; }
        public float PorcentagemComissaoPrata { get; private set; }
        public float PorcentagemComissaoOuro { get; private set; }
        public float PorcentagemComissaoDiamante { get; private set; }
    }
}
