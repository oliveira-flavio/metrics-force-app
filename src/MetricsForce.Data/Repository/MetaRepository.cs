using AppMetricsForce.App.Data.Context;
using AppMetricsForce.Models;
using MetricsForce.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsForce.Data.Repository
{
    public class MetaRepository : Repository<Meta>, IMetaRepository
    {
        public MetaRepository(MetricsDbContext context) : base(context) { }

        //Métodos
    }
}
