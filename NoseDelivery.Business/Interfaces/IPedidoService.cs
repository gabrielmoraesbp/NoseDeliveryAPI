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


        Task<string> AdicionarPedido(Pedido pedido);
        Task<string> AlterarStatus(StatusPedido status, Guid Id);
        Task<string> RemoverPedido(Guid id);

    }
}
