using ContosoPizza.Data;
using ContosoPizza.Models;

namespace ContosoPizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ContosoPizzaContext context = new ContosoPizzaContext();

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
                Console.WriteLine( $"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine(new string('-',20));
            }

            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }

        static void CreateData(ContosoPizzaContext context)
        {
            var veggieSpecial = new Product()
            {
                Name = "Veggie special Pizza",
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
