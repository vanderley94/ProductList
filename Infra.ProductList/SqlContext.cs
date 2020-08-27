using ListagemProduto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.ProductList
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options)
        :base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductPhoto> ProductPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new ClienteConfiguration());
            //modelBuilder.Configurations.Add(new ProdutoConfiguration());

            modelBuilder.Entity<Product>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<ProductPhoto>()
                .HasOne(p => p.Products)
                .WithMany(p => p.Photo)
                .HasForeignKey(p => p.IdProduct)
                .HasPrincipalKey(p => p.Name);



        }

    }
}
