using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NoseDelivery.Business.Models
{
    public class ProdutoParaPedido
    {

        public Guid PedidoId { get; set; }
        public Guid ProdutoId { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }


    }
}
