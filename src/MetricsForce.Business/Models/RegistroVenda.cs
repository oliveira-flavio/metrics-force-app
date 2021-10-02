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
        public Vendedor Vendedor { get; set; }
        public int QuantidadeItens { get; set; }
        public decimal ValorVenda { get; set; }
        public PercentualComissao Comissao { get; set; }

    }
}
