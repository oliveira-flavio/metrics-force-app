using MetricsForce.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public class Vendedor : Usuario
    {
        public ICollection<Meta> Metas { get; private set; }
        public ICollection<Comissao> Comissoes { get; private set; }
        public ICollection<IndicadorDePerformance> IndicadoresDePerformance { get; private set; }
    }
}
