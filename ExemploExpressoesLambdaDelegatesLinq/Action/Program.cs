using System;
using Exemplos.Entities;
using System.Collections.Generic;

namespace ExemploAction
{

    delegate void BinaryNumericOperation(double n1, double n2); // Declaração do Delegate

    class Program
    {
        static void Main(string[] args)
        {
            // Adiciona na lista o valor do Produto + 10%
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = UpdatePrice;
            // Action<Product act = p => { p.Price += p.Price * 0.1; };

            // list.ForEach(UpdatePrice);
            list.ForEach(act);
            // list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // Função auxiliar
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}