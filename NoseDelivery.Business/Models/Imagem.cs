using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models
{
    public class Imagem : Entity
    {
        public Produto Produto { get; set; }
        public string Rota { get; set; }
    }
}
