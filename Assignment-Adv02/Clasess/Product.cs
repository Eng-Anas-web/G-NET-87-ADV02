using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Adv02.Clasess
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }



        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (filter(products[i]))
                {
                    result.Add(products[i]);
                }
            }
            return result;
        }

        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }

        public static List<T> TransformProducts<T>(List<Product> products, Func<Product , T> filter)
        {
            List<T> result = new List<T> ();
            for(int i = 0;i<products.Count; i++)
            {
                result.Add(filter(products[i]));
            }
            return result;
        }
    }

}