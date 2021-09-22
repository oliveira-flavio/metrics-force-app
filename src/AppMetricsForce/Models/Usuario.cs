using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public class Usuario
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string CodigoFuncionario { get; set; }
        public Cargos Cargo { get; set; }
        public bool Ativo { get; set; }

    }
}
