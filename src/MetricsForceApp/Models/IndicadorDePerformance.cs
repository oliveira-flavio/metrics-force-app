using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class IndicadorDePerformance : Entity
    {
        [Display(Name = "Ticker Médio")]
        public decimal TicketMedio { get; set; }
        [Display(Name ="Quantidade Venda")]
        public int QuantidadeVenda { get; set; }
        public DateTime Data { get; set; }
        public Vendedor Vendedor { get; set; }
        public Gerente Gerente { get; set; }
    }
}
