using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Business.Models
{
    public class Comissao
    {
        public int IdComissao { get; private set; }
        public int IdUsuario { get; private set; }
        public PercentualComissao PercentualComissao { get; private set; }
    }
}
