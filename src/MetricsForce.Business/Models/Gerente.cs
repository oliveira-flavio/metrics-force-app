using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public class Gerente : Usuario
    {
        public decimal Comissao { get; set; }
        public ICollection<Meta> Meta { get; set; }
    }
}
