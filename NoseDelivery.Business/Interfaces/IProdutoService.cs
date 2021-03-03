using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task<string> AdicionarNovoProduto(Produto produto);
        Task<string> AtualizarProduto(Guid Id);
        Task<string> DeletarProduto(Guid id);

    }
}
