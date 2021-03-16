using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NoseDelivery.API.Controllers;
using NoseDelivery.API.ViewModels;
using NoseDelivery.Business.Interfaces;
using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoseDelivery.API.Versao_1._0
{
    [Route("produto")]
    [ApiController]
    public class ProdutoController : MainController
    {

        private readonly IMapper _mapper;
        private readonly IProdutoService _produtoService;

        public ProdutoController(
                                 IMapper mapper,
                                 IProdutoService produtoService)
        {

            _mapper = mapper;
            _produtoService = produtoService;
        }

        [Route("cardapio")]
        [HttpGet]
        public async Task<ActionResult> ObterTodos()
        {
            var obtiveTodos = _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoService.ObterCardapio());

            return Ok(obtiveTodos);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProdutoViewModel>> BuscarProduto(Guid id)
        {
            var obtiveProduto = _mapper.Map<ProdutoViewModel>(await _produtoService.ObterProdutoPorId(id));

            if (obtiveProduto == null) return NotFound();

            return Ok(obtiveProduto);
        }

        [Route("cadastrar")]
        [HttpPost]
        public async Task<ActionResult<ProdutoViewModel>> CadastrarProduto(ProdutoViewModel produtoViewmodel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _produtoService.AdicionarNovoProduto(_mapper.Map<Produto>(produtoViewmodel));

            return Ok();

        }

        [HttpPut]
        [Route("atualizar/{id:guid}")]
        public async Task<IActionResult> AlterarProduto(Guid id, ProdutoViewModel produtoViewModel)
        {

            if (!ModelState.IsValid) return BadRequest();
            var produto = await _produtoService.AtualizarProduto(id, produtoViewModel);
            if (produto == false) return NotFound();
            return Ok();

        }

        [HttpDelete]
        [Route("deletar/{id:guid}")]
        public async Task<ActionResult> RemoverProduto(Guid id)
        {
            //if (id == null) return NotFound();

            await _produtoService.DeletarProduto(id);

            return Ok();

        }

    }
}
