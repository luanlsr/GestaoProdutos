using FluentValidation;
using GestaoProdutos.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Validation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() 
        {
            RuleFor(product => product.Id)
                .NotEmpty().WithMessage("O ID é obrigatório.");
            RuleFor(product => product.Name)
                .NotEmpty().WithMessage("Nome é obrigatória")
                .Matches(@"^[a-zA-Z0-9\s]{3,50}$")
                .WithMessage("Nome inválido. Deve conter apenas letras, números e espaços em branco")
                .MinimumLength(3).WithMessage("Nome deve ser maior que {1} caracteres")
                .MaximumLength(50).WithMessage("Nome deve ser menor que {1} caracteres");
            RuleFor(product => product.Description)
                .NotEmpty().WithMessage("Descrição é obrigatória")
                .Matches(@"^[a-zA-Z0-9\s]{3,50}$")
                .WithMessage("Descrição inválida. Deve conter apenas letras, números e espaços em branco")
                .MinimumLength(3).WithMessage("Descrição deve ser maior que {1} caracteres")
                .MaximumLength(150).WithMessage("Descrição deve ser menor que {1} caracteres");
            RuleFor(product => product.Price)
                .NotNull().WithMessage("O preço não pode ser nulo.")
                .GreaterThan(0).WithMessage("O preço deve ser maior do que zero.");
            RuleFor(product => product.Quantity)
                .NotNull().WithMessage("A quantidade não pode ser nula.");
            RuleFor(product => product.CategoryId)
                .NotEmpty().WithMessage("O CategoryId é obrigatório.");
            RuleFor(product => product.StockId)
                .NotEmpty().WithMessage("O StockId é obrigatório.");
        }
    }
}
