﻿
using System.Data.Entity;

namespace IndividualLabAssignment.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("IndividualLabAssignment")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

    }
}

