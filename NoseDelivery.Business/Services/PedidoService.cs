using NoseDelivery.Business.Enums;
using NoseDelivery.Business.Interfaces;
using NoseDelivery.Business.Models;
using NoseDelivery.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Business.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoService _pedidoService;

        public PedidoService(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
                      
        }


        public async Task AdicionarPedido(Pedido pedido)
        {
            if (pedido == null) return;

            await _pedidoService.AdicionarPedido(pedido);
        }

        public async Task StatusPedido(StatusEntrega status)
        {
            await _pedidoService.StatusPedido(status);
        }


        public  async Task RemoverPedido(Guid id)
        {
            await _pedidoService.RemoverPedido(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
