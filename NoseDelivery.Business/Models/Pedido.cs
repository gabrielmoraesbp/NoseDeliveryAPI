using NoseDelivery.Business.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models
{
    public class Pedido : Entity
    {
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public StatusPedido Status { get; set; }

        public Cliente Cliente { get; set; }
        public ICollection<ProdutoParaPedido> ProdutosParaPedidos { get; set; }

    }
}
