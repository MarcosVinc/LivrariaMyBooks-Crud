using FluentValidation;
using MyBooksEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksServiços.Validações
{
    public class ValidacaoLivro : AbstractValidator<Livros>
    {
        public ValidacaoLivro()
        {
            RuleFor(x => x.Atuacao).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Titulo).NotNull().NotEmpty().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Autor).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Editora).NotEmpty().NotNull().MinimumLength(3).MaximumLength(60);
            RuleFor(x => x.Edicao).NotEmpty();
            RuleFor(x => x.Volume).NotEmpty();

        }
    }
}
