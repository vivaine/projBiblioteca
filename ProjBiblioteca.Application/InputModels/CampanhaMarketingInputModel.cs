using System;
using FluentValidation;

namespace ProjBiblioteca.Application.InputModels
{
    public class CampanhaMarketingInputModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public double PercentualDesconto { get; set; }
        
        
        
        
        
        
    }

    public class CampanhaMarketingValidator : AbstractValidator<CampanhaMarketingInputModel>
    {
        public CampanhaMarketingValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("A descrição é obrigatória.")
                        .Length(0, 100).WithMessage("A descrição não pode exceder 100 caracteres.");
        }
    }
}