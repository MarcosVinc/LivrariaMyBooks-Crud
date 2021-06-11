using FluentValidation;
using MyBooksEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksServiços.Validações
{
    public class ValidacaoRequisitoA : AbstractValidator<Requisitante>
    {
        public ValidacaoRequisitoA() 
        {
            RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Telefone).NotNull().NotEmpty().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Email).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
           

        }
    }
}
