using Microsoft.EntityFrameworkCore;
using project_tz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tz.Metod
{
    public class AddMethod
    {
        public static string AddProduct(Guid Id, string name, double price, string Description)
        {

            string result = "Product already exists";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.Migrate();
                bool check = db.Products.Any(el => el.Name == name && el.Price == price && el.Description == Description && el.Id==Id);
                if (!check)
                {
                    Product newproduct = new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Price = price,
                        Description = Description,
                      
                    };
                    db.Products.Add(newproduct);
                    db.SaveChanges();
                    result = "Added";
                }
                return result;
            }
        }
    }
}

