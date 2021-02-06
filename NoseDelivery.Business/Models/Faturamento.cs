using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models
{
    public class Faturamento : Entity
    {
        public DateTime Periodo { get; set; }
        public double Valor { get; set; }

    }
}
