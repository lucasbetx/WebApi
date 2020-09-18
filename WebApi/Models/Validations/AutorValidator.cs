using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models.Entities;

namespace WebApi.Models.Validations
{
    public class AutorValidator : AbstractValidator<Autor>
    {
        public AutorValidator()
        {
            RuleFor(a => a.Nome)
                .NotNull().WithMessage("O Nome do Autor é obrigatório.")
                .NotEmpty().WithMessage("O Nome do Autor é obrigatório.")
                .Length(3, 100).WithMessage("O Nome do Autor dever ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(a => a.Email)
                .NotNull().WithMessage("O E-Mail do Autor é obrigatório.")
                .NotEmpty().WithMessage("O E-mail do Autor deve ser preenchido");

            RuleFor(a => a.Observacao)
                .MaximumLength(2000).WithMessage("A Observação não deve passar de 2000 caracteres");

            RuleFor(a => a.QuantidadeLivrosVendidos)
                .GreaterThan(0).WithMessage("A quantidade de livros vendidos deve ser maior que zero");

        }
    }
}