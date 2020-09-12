using System;
using System.Globalization;

namespace ExemploConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Produto prod = new Produto(nome, preco);
            Produto produto = new Produto(nome, preco, quantidade);
            Produto produto2 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 5 };

            Console.WriteLine("Dados do produto: " + produto);
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + produto);
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + produto);
            */

            Produto produto = new Produto("TV", 500.00, 10);
            produto.SetNome("Radio");
            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto);
        }
    }
}