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
        public DateTime InicioMeta { get; set; }
        public DateTime FimMeta { get; set; }
        public double RealizadoAteDataAtual { get; set; }
        public double MetaBronze { get; set; }
        public double MetaPrata { get; set; }
        public double MetaOuro { get; set; }
        public double MetaDiamante { get; set; }

    }
}
