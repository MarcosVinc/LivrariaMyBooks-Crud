using FluentValidation;
using MyBooksEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksServiços.Validações
{
    public class ValidacaoUsuario : AbstractValidator<LoginUsuarios>
    {
        public ValidacaoUsuario() 
        {
            RuleFor(x => x.Login).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Senha).NotNull().NotEmpty();
            RuleFor(x => x.Email).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);

        }
    }
}
