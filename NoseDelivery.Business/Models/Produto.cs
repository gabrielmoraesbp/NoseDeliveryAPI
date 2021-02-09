using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public bool Status { get; set; }
        public int Quantidade { get; set; }
        public ICollection<ProdutoParaPedido> ProdutosParaPedidos { get; set; }

    }
}
