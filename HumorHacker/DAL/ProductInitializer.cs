using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HumorHacker.Models;
using System.Data.Entity;


namespace HumorHacker.DAL
{

    public class ProductInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
            new Product{Name="TShirt",Category="Clothes", Price=750},
            new Product{Name="Coffee mug",Category="Swag", Price=750},
            new Product{Name="mouse pad",Category="Swag", Price=750},
            new Product{Name="Computer Desk",Category="Office", Price=750},
            new Product{Image=$"/Images/debugging on toilet meme.JPG", Name="Phone Charger",Category="Misc.", Price=750},

            };

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}