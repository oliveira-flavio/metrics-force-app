using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Business.Models
{
    public class IndicadorDePerformance
    {
        public int IdIndicadorDePerformance { get; set; }
        public int IdUsuario { get; set; }
        public decimal TicketMedio { get; set; }
        public int QuantidadeVenda { get; set; }
    }
}
