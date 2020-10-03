using System;
using Exemplos.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ExemploFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Transforma os nomes dos produtos em UpperCase
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Func<Product, string> func = NameUpper; // Delegate Func
            // List<string> result = list.Select(func).ToList();

            // Func<Product, string> func = p => p.Name.ToUpper(); // Com Expressão Lambda
            // List<string> result = list.Select(func).ToList();

            // List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            List<string> result = list.Select(NameUpper).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}