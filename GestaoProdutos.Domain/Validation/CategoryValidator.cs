using FluentValidation;
using GestaoProdutos.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Validation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() 
        {
            RuleFor(category => category.Id)
                .NotEmpty()
                .WithName("Id")
                .WithMessage("O ID é obrigatório.");
            RuleFor(category => category.Description)
                .NotEmpty()
                .WithName("description")
                .WithMessage("Descrição é obrigatória")
                .MinimumLength(5).WithMessage("Descrição deve ser maior que {1} caracteres")
                .MaximumLength(150).WithMessage("Descrição deve ser menor que {1} caracteres");
        }
    }
}
