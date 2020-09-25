using System;
using System.Data.Entity;

namespace IndividualLabAssignment.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("IndividualLabAssignmet")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}

