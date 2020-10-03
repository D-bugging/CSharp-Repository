using System;
using Exemplos.Entities;
using System.Collections.Generic;

namespace ExemploPredicate
{

    delegate void BinaryNumericOperation(double n1, double n2); // Declaração do Delegate

    class Program
    {
        static void Main(string[] args)
        {
            // Remove da lista somente aqueles cujo preço mínimo seja 100
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // Função auxiliar
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}