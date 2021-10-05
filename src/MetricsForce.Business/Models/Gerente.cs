using MetricsForce.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public class Gerente : Usuario
    {
        public Comissao Comissao { get; set; }
        public ICollection<Meta> Metas { get; set; }
        public IndicadorDePerformance IndicadoresDePerformance { get; set; }
    }
}
