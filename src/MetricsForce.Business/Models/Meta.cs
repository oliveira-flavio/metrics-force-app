using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Adicionar Seed de vendas para 3 meses cheios, para gerar relatório gerar um seed de um mês corrente,
// até a data da apresentação do trabalho

namespace AppMetricsForce.Models
{
    public class Meta
    {
        public int Id { get; private set; }
        public int IdUsuario { get; private set; }
        public DateTime InicioMeta { get; private set; }
        public DateTime FimMeta { get; private set; }
        public decimal MetaBronze { get; private set; }
        public decimal MetaPrata { get; private set; }
        public decimal MetaOuro { get; private set; }
        public decimal MetaDiamante { get; private set; }
        public Gerente Gerente { get; private set; }
        public Vendedor Vendedor { get; private set; }

    }
}
