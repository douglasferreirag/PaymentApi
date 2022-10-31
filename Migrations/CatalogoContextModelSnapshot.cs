﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payment_api.Context;

#nullable disable

namespace PaymentApi.Migrations
{
    [DbContext(typeof(CatalogoContext))]
    partial class CatalogoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Payment_api.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<double>("Quantidade")
                        .HasPrecision(14, 2)
                        .HasColumnType("float(14)");

                    b.Property<double>("Valor")
                        .HasPrecision(14, 2)
                        .HasColumnType("float(14)");

                    b.Property<int?>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProduto");

                    b.HasIndex("VendaId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("Payment_api.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("Valor")
                        .HasPrecision(14, 2)
                        .HasColumnType("float(14)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Payment_api.Entities.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoPedido")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Payment_api.Entities.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Payment_api.Entities.Item", b =>
                {
                    b.HasOne("Payment_api.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payment_api.Entities.Venda", null)
                        .WithMany("Itens")
                        .HasForeignKey("VendaId");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Payment_api.Entities.Venda", b =>
                {
                    b.HasOne("Payment_api.Entities.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Payment_api.Entities.Venda", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
