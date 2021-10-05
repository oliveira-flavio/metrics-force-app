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
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime InicioMeta { get; set; }
        public DateTime FimMeta { get; set; }
        public decimal MetaBronze { get; set; }
        public decimal MetaPrata { get; set; }
        public decimal MetaOuro { get; set; }
        public decimal MetaDiamante { get; set; }
        public Gerente Gerente { get; set; }
        public Vendedor Vendedor { get; set; }

    }
}
