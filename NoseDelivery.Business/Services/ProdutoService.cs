using NoseDelivery.Business.Interfaces;
using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Business.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<string> AdicionarNovoProduto(Produto produto)
        {
            await _produtoRepository.Adicionar(produto);
            return "Produto Adicionado com sucesso!";
        }

        public async Task<string> AtualizarProduto(Guid id)
        {
            var produtoCompleto = await _produtoRepository.ObterPorId(id);

            if (produtoCompleto == null) return "Produto não encontrado";

            await _produtoRepository.Atualizar(produtoCompleto);
            return "Produto Atualizado";
        }

        public async Task<string> DeletarProduto(Guid id)
        {
            var produtoCompleto = await _produtoRepository.ObterPorId(id);
            if (produtoCompleto == null) return "Produto não encontrado";

            await _produtoRepository.Remover(produtoCompleto);
            return "Produto Removido";
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }

     
    }
}
