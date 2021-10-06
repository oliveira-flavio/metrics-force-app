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
    public class GerenteRepository : Repository<Gerente>, IGerenteRepository
    {
        public GerenteRepository(MetricsDbContext context) : base(context) { }

        //Métodos
    }


}
