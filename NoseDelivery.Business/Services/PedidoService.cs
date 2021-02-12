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
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
                      
        }


        public async Task AdicionarPedido(Pedido pedido)
        {

            //var lista = _pedidoRepository.Buscar(p => p.Data == PassarDataComoParametro);
        }

        public async Task StatusPedido(StatusPedido status)
        {
            //await _pedidoService.StatusPedido(status);
        }


        public  async Task RemoverPedido(Guid id)
        {
            //await _pedidoService.RemoverPedido(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
