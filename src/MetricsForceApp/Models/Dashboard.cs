using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class Dashboard : Entity
    {
        public decimal ValorRealizado { get; set; }
        public decimal MetaMensal { get; set; }
        public float PorcentagemAtingida { get; set; }
    }
}
