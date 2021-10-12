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
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal TicketMedio { get; private set; }
        [Display(Name ="Quantidade Venda")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int QuantidadeVenda { get; private set; }
        public DateTime Data { get; private set; }
        public Vendedor Vendedor { get; private set; }
        public Gerente Gerente { get; private set; }
    }
}
