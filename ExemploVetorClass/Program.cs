using System;
using System.Globalization;

namespace ExemploVetorClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos: ");
            int qtdProduto = int.Parse(Console.ReadLine());
            Product[] produto = new Product[qtdProduto];
            double media = 0.0;
            for (int i = 0; i < qtdProduto; i++)
            {
                Console.WriteLine("Digite o {0} produto: ", i + 1);
                string name = Console.ReadLine();

                Console.WriteLine("Digite o {0} valor: ", i + 1);
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produto[i] = new Product { Name = name, Price = price };
                media += produto[i].Price;
            }
            Console.WriteLine("Média dos produtos: " + (media / qtdProduto).ToString("F2", CultureInfo.InvariantCulture));
            /*
            Console.WriteLine("Digite a quantidade de pessoas: ");
            int qtdPessoas = int.Parse(Console.ReadLine());
            double[] altura = new double[qtdPessoas];
            double media = 0.0;
            for (int i = 0; i < qtdPessoas; i++)
            {
                Console.WriteLine("Digite a {0} altura: ", i + 1);
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media += altura[i];
            }
            Console.WriteLine("Altura média: " + (media / qtdPessoas).ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}