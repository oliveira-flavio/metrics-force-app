using MetricsForce.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public class Vendedor : Usuario
    {
        public Comissao Comissao { get; private set; }
        public ICollection<Meta> Metas { get; private set; }
        public IndicadorDePerformance IndicadoresDePerformance { get; private set; }

    }
}
