﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models
{
    public class Pedido : Entity
    {
        public double Valor { get; set; }
        public DateTime Data_Pedido { get; set; }
        public bool Status { get; set; }

        public Cliente Cliente { get; set; }
        public ICollection<Produto_Para_Pedido> Produtos_Para_Pedidos { get; set; }

    }
}
