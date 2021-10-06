using AppMetricsForce.App.Data.Context;
using MetricsForce.Business.Interfaces;
using MetricsForce.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Data.Repository
{
    public class PercentualComissaoRepository : Repository<PercentualComissao>, IPercentualComissaoRepository
    {
        public PercentualComissaoRepository(MetricsDbContext context) : base(context) { }

        //Métodos
    }
}
