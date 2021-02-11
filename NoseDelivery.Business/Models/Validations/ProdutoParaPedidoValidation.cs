using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models.Validations
{
    public class ProdutoParaPedidoValidation : AbstractValidator<Produto>
    {
       public ProdutoParaPedidoValidation()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.Quantidade).NotEmpty();
        }

    }
}
