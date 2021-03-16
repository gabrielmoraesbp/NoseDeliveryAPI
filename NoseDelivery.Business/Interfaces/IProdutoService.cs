using NoseDelivery.API.ViewModels;
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
        Task<Produto> ObterProdutoPorId(Guid id);
        Task <List<Produto>> ObterCardapio();
        Task<bool> AtualizarProduto(Guid id, ProdutoViewModel produtoViewModel);
        Task<string> DeletarProduto(Guid id);

    }
}
