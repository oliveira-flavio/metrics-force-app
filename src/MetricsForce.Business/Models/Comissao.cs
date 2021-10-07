﻿using AppMetricsForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Business.Models
{
    public class Comissao : Entity
    {
        public int IdUsuario { get; private set; }
        public int IdPercentualComissao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Mes { get; private set; }
        public PercentualComissao PercentualComissao { get; private set; }
        public Vendedor Vendedor { get; private set; }
        public Gerente Gerente { get; private set; }
    }
}