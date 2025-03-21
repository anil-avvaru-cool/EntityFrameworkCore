using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza
{
    internal class Program
    {
        static string veggie = "Veggie special Pizza";

        static void Main(string[] args)
        {
            using ContosoPizzaContext context = new ContosoPizzaContext();

            //CreateData(context);
            //UpdateData(context);
            DeleteData(context);
            GetData(context);

            Console.WriteLine("Completed");
            Console.ReadKey();
        }

        static void DeleteData(ContosoPizzaContext context)
        {
            var veggieSP = context.Products.Where(p => p.Name == veggie).FirstOrDefault();

            if (veggieSP is Product)
            {
                context.Products.Remove(veggieSP);
            }

            context.SaveChanges();
        }

        static void UpdateData(ContosoPizzaContext context)
        {
            Product? veggieSP = context.Products.Where(p => p.Name == veggie).FirstOrDefault();
            

            if(veggieSP is Product)
            {
                veggieSP.Price = 10.99M;
            }
            context.Attach(veggieSP).State = EntityState.Modified;

            context.SaveChanges();
        }

        static void GetData(ContosoPizzaContext context)
        {            

            // Fluent syntax
            //var products = context.Products
            //    .Where(p => p.Price > 10.00M)
            //    .OrderBy(p => p.Name);

            //Linq query
            var products = from product in context.Products
                           where product.Price > 10.00M
                           orderby product.Name
                           select product;

            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine(new string('-', 20));
            }
        }

        static void CreateData(ContosoPizzaContext context)
        {
            var veggieSpecial = new Product()
            {
                Name = veggie,
                Price = 9.9M
            };

            context.Products.Add(veggieSpecial);

            var meatPizza = new Product()
            {
                Name = "Delux Meat Pizza",
                Price = 12.99M
            };
            context.Add(meatPizza);

            context.SaveChanges();
        }
    }
}
