using FluentValidation;

namespace ProjBiblioteca.Application.InputModels
{
    public class GeneroInputModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }
    }

    public class GeneroInputmodelValidator : AbstractValidator<GeneroInputModel>
    {
        public GeneroInputmodelValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("A descrição é obrigatória.")
                    .Length(0, 100).WithMessage("A descrição não pode exceder 100 caracteres.");
        }
    }
}