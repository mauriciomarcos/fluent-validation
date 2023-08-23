using Domains.Entites;
using FluentValidation;

namespace Application.Validations;

public class AlunoValidator : AbstractValidator<Aluno>
{
	public AlunoValidator()
	{
        When(e => e == null, () =>
        {
            RuleFor(e => e).NotNull();
        })
        .Otherwise(() =>
        {
            RuleFor(e => e.Nome)
            .NotEmpty()
            .WithMessage("Informe o nome do aluno.")
            .Length(3, 50)
            .WithMessage("O nome deve possuir entre 3 e 50 caracteres");

            RuleFor(e => e.Email)
                .NotEmpty()
                .WithMessage("Informe o e-mail do aluno.")
                .EmailAddress()
                .WithMessage("E-mail inválido");

            RuleFor(e => e.DataNascimento)
                .NotEmpty()
                .WithMessage("Informe a data de nascimento do aluno.")
                .Must(ValidarMaioridade)
                .WithMessage("O alumo deve possuir mais de 18 anos.");
        });		
	}

	private static bool ValidarMaioridade(DateTime dataNascimento) => dataNascimento <= DateTime.Now.AddYears(-18);
}