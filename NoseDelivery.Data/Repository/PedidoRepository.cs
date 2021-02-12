using NoseDelivery.Business.Enums;
using NoseDelivery.Business.Interfaces;
using NoseDelivery.Business.Models;
using NoseDelivery.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace NoseDelivery.Data.Repository
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {

        public PedidoRepository(MeuDbContext context) : base(context) { }

        public async Task AlterarStatusDoPedido(StatusPedido status, Pedido pedido)
        {
            var pedidoCliente = await ObterPorId(pedido.Id);

            pedidoCliente.Status = status;

            await Atualizar(pedidoCliente);
           
        }

        public async Task<Pedido> ObterHistoricoCliente(string telefone)
        {
            throw new NotImplementedException();

        }
        public override async Task<List<Pedido>> ObterTodos()
        {
            return await DbSet.AsNoTracking()
                .Include(p => p.ProdutosParaPedidos)
                .Include(c => c.Cliente)
                .OrderBy(d => d.Data)
                .ToListAsync();
        }

        public override async Task<IEnumerable<Pedido>> Buscar(Expression<Func<Pedido, bool>> predicate)
        {
            return await DbSet.AsNoTracking()
                .Include(p => p.ProdutosParaPedidos)
                .Include(p => p.Cliente)
                .Where(predicate)
                .OrderBy(p => p.Data)
                .ToListAsync();
        }

        public Task<IEnumerable<Pedido>> ObterPedidosPorData(DateTime dataPedido)
        {
            throw new NotImplementedException();
        }



    }
}
