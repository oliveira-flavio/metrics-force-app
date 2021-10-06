using AppMetricsForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Business.Models
{
    public class RegistroVenda
    {
        public int IdVenda { get; private set; }    
        public int QuantidadeItem { get; private set; }
        public decimal ValorVenda { get; private set; }
        public int QuantidadeTicket { get; private set; }
        public DateTime Data { get; set; }
        public ICollection<Vendedor> Vendedor { get; private set; }

    }
}
