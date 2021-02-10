using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Business.Models.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.UserName)
                .NotEmpty()
                .WithMessage("O Campo {PropertyName} precisa ser preenchido.")
                .Length(2, 40)
                .WithMessage("O Campo {PropertyName} precisa ter entre {MinLength} e {MaxLenght} caracteres.");

            RuleFor(c => c.Localizacao)
                .NotEmpty()
                .WithMessage("O Campo {PropertyName} precisa preenchido.")
                .Length(2, 250)
                .WithMessage("O Campo {PropertyName} precisar ter entre{MinLegth} e {MaxLenght} caracteres.");

            RuleFor(c => c.Telefone)
                .NotEmpty()
                .WithMessage("O Campo {PropertyName} precisa ser preenchido.")
                .Length(8, 11)
                .WithMessage("Preencha o telefone corretamente entre {MinLegth} e {MaxLenght} digitos.");
                      

        }

    }
}
