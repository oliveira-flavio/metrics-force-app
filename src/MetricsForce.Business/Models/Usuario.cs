﻿using MetricsForce.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMetricsForce.Models
{
    public abstract class Usuario : Entity
    {     
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public string CodigoFuncionario { get; private set; }
        public bool Ativo { get; private set; }
    }
}