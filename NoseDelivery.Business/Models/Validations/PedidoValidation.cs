using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models.Validations
{
    public class PedidoValidation : AbstractValidator<Pedido>
    {
        public PedidoValidation()
        {
            //RuleFor(c => c.Status).

        }

    }
}
