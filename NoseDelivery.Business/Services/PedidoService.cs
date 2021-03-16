﻿using NoseDelivery.Business.Enums;
using NoseDelivery.Business.Interfaces;
using NoseDelivery.Business.Models;
using NoseDelivery.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace NoseDelivery.Business.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidoService(IPedidoRepository pedidoRepository,
                            IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }


        public async Task<string> AdicionarPedido(Pedido pedido)
        {

            await _pedidoRepository.Adicionar(pedido);

            return "Pedido realizado com sucesso!";

        }

        public async Task<string> AlterarStatus(StatusPedido status, Guid Id)
        {
            var pedidoCompleto = await _pedidoRepository.ObterPorId(Id);

            if (pedidoCompleto == null)
            {
                return "Pedido não encontrado";
            }
            if (pedidoCompleto.Status == status)
            {
                return "A Alteração que esta tentando fazer é a atual.";
            }
            await _pedidoRepository.AlterarStatusDoPedido(status, pedidoCompleto);
            return "Status Alterado";
        }


        //public async Task<string> RemoverPedido(Guid id)
        //{
        //    var pedidoCompleto = await _pedidoRepository.ObterPorId(id);

        //    if (pedidoCompleto == null)
        //    {
        //        return "Pedido não encontrado";
        //    }

        //    await _pedidoRepository.Remover(id);
        //    return "Pedido removido com sucesso";

        //}
               
        public void Dispose()
        {
            _pedidoRepository?.Dispose();
        }

        public Task<string> RemoverPedido(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
