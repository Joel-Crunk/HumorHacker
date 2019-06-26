using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HumorHacker.Models;
using System.Data.Entity;


namespace HumorHacker.DAL
{

    public class ProductInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
            new Product{Image="/Images/TShirt.jpg",Name="TShirt",Category="Clothes", Price=7},
            new Product{Image="/Images/CoffeeMug.jpg",Name="Coffee mug",Category="Swag", Price=15},
            new Product{Image="/Images/MousePad.jpg",Name="mouse pad",Category="Swag", Price=5},
            new Product{Image="/Images/ComputerDesk.jpg",Name="Computer Desk",Category="Office", Price=750},
            new Product{Image="/Images/PhoneCharger.JPG", Name="Phone Charger",Category="Misc.", Price=5},
            //new Product{Image="/Images/My feature their bug.JPG", Name="Phone Charger",Category="Misc.", Price=750}

            };

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}