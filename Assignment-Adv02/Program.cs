

using Assignment_Adv02.Clasess;
using System.Globalization;

namespace Assignment_Adv02
{

    internal class Program
    {


        static void Main(string[] args)
        {

            List<Product> catalog = new()
        {
            new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
            new Product { Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25 },
            new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
            new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
            new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
            new Product { Id=9,Name="Headphones", Category="Electronics", Price=150, Stock=40 },
            new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
        };
            #region Question01
            //Console.WriteLine("\n====Electronics====");
            //List<Product> products = Product.SearchProducts(catalog, filter => filter.Category == "Electronics");
            //foreach(Product product in products)
            //{
            //    Console.WriteLine($"{product.Name} - {product.Price}$ (Stock: {product.Stock})");
            //}
            //Console.WriteLine("\n====Under 50$====");
            //List<Product> productsUnder50 = Product.SearchProducts(catalog, filter => filter.Price < 50);
            //foreach (Product product in productsUnder50)
            //{
            //    Console.WriteLine($"{product.Name} - {product.Price}$ (Stock: {product.Stock})");
            //}
            //Console.WriteLine("\n====In Stock====");
            //List<Product> productsStock = Product.SearchProducts(catalog, filter => filter.Stock > 0);
            //foreach (Product product in productsStock)
            //{
            //    Console.WriteLine($"{product.Name} - {product.Price}$ (Stock: {product.Stock})");
            //}
            //Console.WriteLine("\n====Clothing Under 100$====");
            //List<Product> productsClothing = Product.SearchProducts(catalog, filter => filter.Category == "Clothing" && filter.Price < 100);
            //foreach (Product product in productsClothing)
            //{
            //    Console.WriteLine($"{product.Name} - {product.Price}$ (Stock: {product.Stock})");
            //}
            #endregion

            #region Question02
            //Console.WriteLine("\n====Short Report====");
            // Product.PrintReport(catalog, filter => Console.WriteLine($"{filter.Name} - {filter.Price}$"));
            //Console.WriteLine("\n====Datiles Report====");
            //Product.PrintReport(catalog, filter => Console.WriteLine($"{filter.Name} | {filter.Price}$ | Sock: {filter.Stock} [{filter.Category}]"));
            #endregion
        }

    }
}
