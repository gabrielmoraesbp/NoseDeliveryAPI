using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoseDelivery.API.ViewModels
{
    public class PedidoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(40, 
            ErrorMessage = "O campo {0} precisa ter entre {2} e " +
            "{1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
            [StringLength(11,
            ErrorMessage = "O campo {0} precisa ter entre {2} e " +
            "{1} caracteres", MinimumLength = 8)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(250,
            ErrorMessage = "O campo {0} precisa ter entre {2} e " +
            "{1} caracteres", MinimumLength = 10)]
        public string Localizacao { get; set; }

        //produto

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public List<ProdutoParaPedidoViewModel> ListaDeProdutos{ get; set; }


    }
}
