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
        public int IdVenda { get; set; }    
        public int QuantidadeItem { get; set; }
        public decimal ValorVenda { get; set; }
        public int QuantidadeVenda { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; }
        public PercentualComissao PercentualComissao { get; set; }

    }
}
