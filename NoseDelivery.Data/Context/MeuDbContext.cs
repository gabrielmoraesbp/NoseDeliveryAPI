using Microsoft.EntityFrameworkCore;
using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace NoseDelivery.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Faturamento> Faturamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Imagem> Imagems { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Produto_Para_Pedido> Produtos_Para_Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto_Para_Pedido>()
                .HasKey(x => new { x.ProdutoId, x.PedidoId });
        }


    }
}
