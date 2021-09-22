using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public class Meta
    {
        public int Id { get; set; }
        public DateTime InicioMeta { get; set; }
        public DateTime FimMeta { get; set; }
        public double RealizadoAteDataAtual { get; set; }
        public double MetaBronze { get; set; }
        public double MetaPrata { get; set; }
        public double MetaOuro { get; set; }
        public double MetaDiamante { get; set; }

    }
}
