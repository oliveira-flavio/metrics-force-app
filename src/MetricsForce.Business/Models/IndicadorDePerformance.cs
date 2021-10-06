using AppMetricsForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Business.Models
{
    public class IndicadorDePerformance : Entity
    {
        public int IdUsuario { get; private set; }
        public decimal TicketMedio { get; private set; }
        public int QuantidadeVenda { get; private set; }
        public DateTime Data { get; private set; }
        public Vendedor Vendedor { get; private set; }
        public Gerente Gerente { get; private set; }
    }
}
