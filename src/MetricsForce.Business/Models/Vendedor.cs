using MetricsForce.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public class Vendedor : Usuario
    {
        public Comissao Comissao { get; set; }
        public ICollection<Meta> Metas { get; set; }
        public IndicadorDePerformance IndicadoresDePerformance { get; set; }

        //Bonus por atingimento de meta diamante.
        //Ao cadastrar meta, gerente pode informar se a meta diamante possui bonus por atingimento
        //Existindo bonus, informar o valor do bonus pelo atingimento
        //No dashboard do vendedor, mostrar quanto falta para ele conquistar a meta

    }
}
