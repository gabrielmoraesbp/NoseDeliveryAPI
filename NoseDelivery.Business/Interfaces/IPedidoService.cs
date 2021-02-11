using NoseDelivery.Business.Enums;
using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Business.Interfaces
{
    public interface IPedidoService : IDisposable
    {
        Task AdicionarPedido(Pedido pedido);
        Task StatusPedido(StatusEntrega status);
        Task RemoverPedido(Guid id);

    }
}
