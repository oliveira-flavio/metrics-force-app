using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class RegistroVenda : Entity
    {
        public int QuantidadeItem { get; set; }
        public decimal ValorVenda { get; set; }
        public int QuantidadeTicket { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; }
    }
}
