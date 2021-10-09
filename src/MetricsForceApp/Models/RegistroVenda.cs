using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    public class RegistroVenda : Entity
    {
        public int QuantidadeItem { get; private set; }
        public decimal ValorVenda { get; private set; }
        public int QuantidadeTicket { get; private set; }
        public DateTime Data { get; set; }
        public ICollection<Vendedor> Vendedor { get; private set; }
    }
}
