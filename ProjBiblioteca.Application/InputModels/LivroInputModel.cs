using System.Collections.Generic;
using FluentValidation;
using ProjBiblioteca.Application.DTOs;

namespace ProjBiblioteca.Application.InputModels
{
    public class LivroInputModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int? Quantidade { get; set; }

        public string Foto { get; set; }

        public int? Ano { get; set; }

        public int? Edicao { get; set; }

        public int? Paginas { get; set; }

        public string Editora { get; set; }
        
        public IList<AutorSelectListDto> Autores { get; set; }

    }

    public class LivroInputModelValidator : AbstractValidator<LivroInputModel>
    {
        public LivroInputModelValidator()
        {
            RuleFor(x => x.Titulo).NotEmpty().WithMessage("O Título é obrigatório.")
                            .Length(0, 100).WithMessage("O Título não pode exceder 100 caracteres.");

            RuleFor(x => x.Quantidade)
                            .GreaterThanOrEqualTo(0).WithMessage("A quantidade não pode ter valor negativo.");

            RuleFor(x => x.Foto).Length(0, 300).WithMessage("O Título não pode exceder 300 caracteres.");                
        }
    }
}