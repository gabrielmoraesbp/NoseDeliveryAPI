﻿using NoseDelivery.Business.Enums;
using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Business.Interfaces
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<IEnumerable<Pedido>> ObterPedidosPorData(DateTime dataPedido);
        Task AlterarStatusDoPedido(StatusPedido status, Pedido pedido);
        Task<IEnumerable<Pedido>> ObterPorStatus(StatusPedido status);

    }
}
