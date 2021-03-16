using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoseDelivery.API.ViewModels
{
    public class ProdutoParaPedidoViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public int Quantidade { get; set; }

    }
}
