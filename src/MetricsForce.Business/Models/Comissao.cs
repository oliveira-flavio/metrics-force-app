using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Business.Models
{
    public class Comissao
    {
        public int IdComissao { get; set; }
        public int IdUsuario { get; set; }
        public PercentualComissao PercentualComissao { get; set; }
    }
}
