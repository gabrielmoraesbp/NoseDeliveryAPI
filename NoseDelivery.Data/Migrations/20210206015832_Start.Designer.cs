﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoseDelivery.Data.Context;

namespace NoseDelivery.Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    [Migration("20210206015832_Start")]
    partial class Start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("NoseDelivery.Business.Models.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Localizacao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Faturamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Periodo")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Faturamentos");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Funcionario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PapelDoCargo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Imagem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Rota")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Imagems");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ClienteId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Data_Pedido")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Produto_Para_Pedido", b =>
                {
                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<Guid?>("PedidoId1")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProdutoId1")
                        .HasColumnType("char(36)");

                    b.HasKey("ProdutoId", "PedidoId");

                    b.HasIndex("PedidoId1");

                    b.HasIndex("ProdutoId1");

                    b.ToTable("Produtos_Para_Pedidos");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Imagem", b =>
                {
                    b.HasOne("NoseDelivery.Business.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Pedido", b =>
                {
                    b.HasOne("NoseDelivery.Business.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Produto_Para_Pedido", b =>
                {
                    b.HasOne("NoseDelivery.Business.Models.Pedido", "Pedido")
                        .WithMany("Produtos_Para_Pedidos")
                        .HasForeignKey("PedidoId1");

                    b.HasOne("NoseDelivery.Business.Models.Produto", "Produto")
                        .WithMany("Produtos_Para_Pedidos")
                        .HasForeignKey("ProdutoId1");

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Pedido", b =>
                {
                    b.Navigation("Produtos_Para_Pedidos");
                });

            modelBuilder.Entity("NoseDelivery.Business.Models.Produto", b =>
                {
                    b.Navigation("Produtos_Para_Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
