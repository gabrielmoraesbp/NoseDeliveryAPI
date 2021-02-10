using NoseDelivery.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace NoseDelivery.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;
        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        //protected void Notificar(ValidationResult validationResult)
        //{           

        //    foreach (var error in validationResult.ErrorMessage)
        //    {
        //        Notificar(error)
        //    }

        //}

    }
}
