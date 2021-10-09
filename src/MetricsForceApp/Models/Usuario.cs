using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(CodigoFuncionario), IsUnique = true)]

    public abstract class Usuario : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage ="O campo {0} pode ter entre {1} e {2} caracteres", MinimumLength = 3)]
        [Display(Name = "Nome")]
        public string Nome { get; private set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "E-mail")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "E-mail inválido!")]
        public string Email { get; private set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(6, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 6)]
        public string CodigoFuncionario { get; private set; }
        [Display(Name = "Ativo?")]
        public bool Ativo { get; private set; }
    }
}
