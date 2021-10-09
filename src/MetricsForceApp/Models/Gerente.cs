using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class Gerente : Usuario
    {
        public ICollection<Comissao> Comissoes { get; private set; }
        public ICollection<Meta> Metas { get; private set; }
        public ICollection<IndicadorDePerformance> IndicadoresDePerformance { get; private set; }
    }
}
