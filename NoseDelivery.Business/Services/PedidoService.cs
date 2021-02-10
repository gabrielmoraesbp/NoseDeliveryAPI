using NoseDelivery.Business.Interfaces;
using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Business.Services
{
    public class PedidoService : IPedidoService
    {
        //private readonly IPedidoRepository _pedidoRepository;


        public Task Adicionar(Pedido pedido)
        {
            throw new NotImplementedException();
        }
             

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
