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
    public class VendedorRepository : Repository<Vendedor>, IVendedorRepository
    {
        public VendedorRepository(MetricsDbContext context) : base(context) { }

        //Métodos
    }
}
