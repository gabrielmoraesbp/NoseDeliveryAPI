using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NoseDelivery.Business.Models
{
    public class Produto_Para_Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        [Key]
        public int ProdutoId { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }


    }
}
