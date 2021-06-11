using FluentValidation;
using MyBooksEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksServiços.Validações
{
    public class ValidacaoRequisitoB : AbstractValidator<Requisitante>
    {
        public ValidacaoRequisitoB()
        {
            RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Telefone).NotNull().NotEmpty().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Email).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Livro).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Volume).NotEmpty();

        }
    }
}
