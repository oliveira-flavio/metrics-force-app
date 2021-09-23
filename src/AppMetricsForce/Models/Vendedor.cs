using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public class Vendedor : Usuario
    {
        public int QuantidadeDeVendas { get; set; }
        public double VendaLiquida { get; set; }
        public int ItensVendidos { get; set; }
        public double TicketMedio { get; set; }

        //Comissão
        //Bonus por atingimento de meta diamante.
        //Ao cadastrar meta, gerente pode informar se a meta diamante possui bonus por atingimento
        //Existindo bonus, informar o valor do bonus pelo atingimento
        //No dashboard do vendedor, mostrar quanto falta para ele conquistar a meta

    }
}
