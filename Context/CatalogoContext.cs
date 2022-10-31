using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Payment_api.Entities;

namespace Payment_api.Context
{
    public class CatalogoContext : DbContext
    {

                public CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options) {

                
        

                }

                 public DbSet<Vendedor> Vendedores { get; set; }

                public DbSet<Produto> Produtos { get; set; }

                public DbSet<Item> Itens { get; set; }

                public DbSet<Venda> Vendas { get; set; }

         }

        
    
}