using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IndividualLabAssignment.Models
{
    public class ProductDatabaseInitializer :
    DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(r => context.Products.Add(r));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category { CategoryID = 2, CategoryName = "Two Doors Sport Car" }, 
                new Category { CategoryID = 5, CategoryName = "4 Doors Sedan Car" },
                new Category{CategoryID=6, CategoryName="SUV"}
            };
            return categories;
        }
        private static List<Product> GetProducts() 
        {
            var products = new List<Product> 
            {
                new Product {
                    ProductID = 1, 
                    ProductName = "Name:Mercedes-Benz CLS",
                    Description = "This lovely new Mercedes-Benz CLS will take you to your destination in comfort and style!" + "",
                    ImagePath="Images/benzRed.jpg",
                    UnitPrice = 21000.00, 
                    CategoryID = 5 },
                new Product {
                    ProductID = 2,
                    ProductName = "Name: BMW M4 Coupe",
                    Description = "Red" + "",
                    ImagePath="Images/BMWRed.jpg",
                    UnitPrice = 25000.00,
                    CategoryID = 2
                    }, 
                new Product {
                    ProductID = 3,
                    ProductName = "Name: Mercedes-Benz C-Class",
                    Description = "White" + "",
                    ImagePath="Images/benzWhite.jpg",
                    UnitPrice = 21000.00,
                    CategoryID = 5
                    },
                new Product {
                    ProductID = 4,
                    ProductName = "Name: BMW 5 Series",
                    Description = "Red" + "",
                    ImagePath="Images/BMWRed.jpg",
                    UnitPrice = 23000.00,
                    CategoryID = 5
                     },
                new Product {
                    ProductID = 5,
                    ProductName = "Name: Mercedes-Benz GLS",
                    Description = "Blue" + "",
                    ImagePath="Images/benzBlue.jpg",
                    UnitPrice = 25000.00,
                    CategoryID = 6
                    },
                new Product {
                    ProductID = 6,
                    ProductName = "Name: BMW M4",
                    Description = "Yellow" + "",
                    ImagePath="Images/BMWYellow.jpg",
                    UnitPrice = 22000.00,
                    CategoryID = 2  }, 
                
                    };
            return products;
        }
    }
}