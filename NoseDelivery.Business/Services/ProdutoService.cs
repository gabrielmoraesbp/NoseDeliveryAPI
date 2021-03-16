using AutoMapper;
using NoseDelivery.API.ViewModels;
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
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository,
                              IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<List<Produto>> ObterCardapio()
        {
            var todosProdutos = await _produtoRepository.ObterTodos();

            return todosProdutos;
        }

        public async Task<Produto> ObterProdutoPorId(Guid Id)
        {
            var obtiveProduto = await _produtoRepository.ObterProdutoPorId(Id);

            return obtiveProduto;
        }


        public async Task<string> AdicionarNovoProduto(Produto produto)
        {
            await _produtoRepository.Adicionar(produto);
            return "Produto Adicionado com sucesso!";
        }

        public async Task<bool> AtualizarProduto(Guid id, ProdutoViewModel produtoViewModel)
        {
            try
            {
                var produtoAtualizacao = await ObterProdutoPorId(id);
                if (produtoAtualizacao == null) return false;
                produtoAtualizacao.Nome = produtoViewModel.Nome;
                produtoAtualizacao.Descricao = produtoViewModel.Descricao;
                produtoAtualizacao.Preco = produtoViewModel.Preco;
                produtoAtualizacao.Quantidade = produtoViewModel.Quantidade;
                            
                await _produtoRepository.Atualizar(produtoAtualizacao);
                return true;
            }

            catch (InvalidOperationException ex)
            {
                throw ex;
            }

        }

        public async Task<string> DeletarProduto(Guid id)
        {
            await _produtoRepository.Remover(id);
            return "Produto Removido";
        }


        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }


    }
}
