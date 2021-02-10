using Microsoft.EntityFrameworkCore;
using NoseDelivery.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace NoseDelivery.Data.Context
{
    public class MeuDbContext : DbContext
    {

        public MeuDbContext()
        {
            
        }
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Faturamento> Faturamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoParaPedido> ProdutosParaPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoParaPedido>()
                .HasKey(x => new { x.ProdutoId, x.PedidoId });

            modelBuilder.Entity<ProdutoParaPedido>()
                .HasOne(p => p.Pedido)
                .WithMany(pp => pp.ProdutosParaPedidos)
                .HasForeignKey(ppp => ppp.PedidoId);


            modelBuilder.Entity<ProdutoParaPedido>()
                .HasOne(p => p.Produto)
                .WithMany(pp => pp.ProdutosParaPedidos)
                .HasForeignKey(ppp => ppp.ProdutoId);

        }

        



    }
}
