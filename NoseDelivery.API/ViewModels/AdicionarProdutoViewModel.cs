using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoseDelivery.API.ViewModels
{
    public class AdicionarProdutoViewModel
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(50,
            ErrorMessage = "O campo {0} precisa ter entre {2} e " +
            "{1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(350,
            ErrorMessage = "O campo {0} precisa ter entre {2} e " +
            "{1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public int Quantidade { get; set; }

    }
}
