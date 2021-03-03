using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoseDelivery.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodosOrderNome(Guid Id);
        Task<IEnumerable<Produto>> ObterTodosOrderPreco(Guid Id);
        
    }
}
