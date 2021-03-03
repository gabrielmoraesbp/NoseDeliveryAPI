using Microsoft.EntityFrameworkCore;
using NoseDelivery.Business.Interfaces;
using NoseDelivery.Business.Models;
using NoseDelivery.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }


        public override async Task<IEnumerable<Produto>> Buscar(Expression<Func<Produto, bool>> predicate)
        {
            return await DbSet
                .AsNoTracking()
                .Where(predicate)
                .OrderBy(c => c.Nome)
                .ToListAsync();
        }

        public override async Task<List<Produto>> ObterTodos()
        {
            return await Db.Produtos
                .AsNoTracking()
                .OrderBy(d => d.Status)
                .ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterTodosOrderNome(Guid Id)
        {
            return await Db.Produtos
                .AsNoTracking()
                .OrderBy(d => d.Nome)
                .ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterTodosOrderPreco(Guid Id)
        {
            return await Db.Produtos
                .AsNoTracking()
                .OrderBy(d => d.Preco)
                .ToListAsync();
        }
    }
}
