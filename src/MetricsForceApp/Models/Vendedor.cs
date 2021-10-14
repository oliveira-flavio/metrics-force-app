using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class Vendedor : Usuario
    {
        public ICollection<Meta> Metas { get; set; }
        public ICollection<Comissao> Comissoes { get; set; }
        public ICollection<IndicadorDePerformance> IndicadoresDePerformance { get; set; }
    }
}
