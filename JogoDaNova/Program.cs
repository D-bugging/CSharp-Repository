using System;

namespace JogoDaNova
{
    class Program
    {
        static void Show(char[,] velha)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(velha[i, 0] + "|" + velha[i, 1] + "|" + velha[i, 2]);
                if (i < 2)
                    Console.WriteLine("------");
            }
        }
        static void Main(string[] args)
        {
            char[,] velha = new char[3, 3];
            bool result = true;
            int linha, coluna;

            while (result)
            {
                Show(velha);

                Console.WriteLine("Primeiro jogador: ");
                Console.Write("Digite a linha: ");
                linha = int.Parse(Console.ReadLine());
                Console.Write("Digite a coluna: ");
                coluna = int.Parse(Console.ReadLine());
                velha[linha, coluna] = 'x';

                Show(velha);

                Console.WriteLine("Segundo jogador: ");
                Console.Write("Digite a linha: ");
                linha = int.Parse(Console.ReadLine());
                Console.Write("Digite a coluna: ");
                coluna = int.Parse(Console.ReadLine());
                velha[linha, coluna] = 'o';

                Console.Clear();

                // Verifica x
                if (velha[0, 0] == 'x' && velha[0, 1] == 'x' && velha[0, 2] == 'x' ||
                    velha[0, 0] == 'x' && velha[1, 0] == 'x' && velha[2, 0] == 'x' ||
                    velha[0, 0] == 'x' && velha[1, 1] == 'x' && velha[2, 2] == 'x' ||
                    velha[0, 1] == 'x' && velha[1, 1] == 'x' && velha[2, 1] == 'x' ||
                    velha[0, 2] == 'x' && velha[1, 2] == 'x' && velha[2, 2] == 'x' ||
                    velha[0, 2] == 'x' && velha[1, 1] == 'x' && velha[2, 0] == 'x' ||
                    velha[1, 0] == 'x' && velha[1, 1] == 'x' && velha[1, 2] == 'x' ||
                    velha[2, 0] == 'x' && velha[2, 1] == 'x' && velha[2, 2] == 'x')
                {
                    Console.WriteLine("Jogador 1 venceu!");
                    result = false;
                }
                // Verifica o
                else if (velha[0, 0] == 'o' && velha[0, 1] == 'o' && velha[0, 2] == 'o' ||
                    velha[0, 0] == 'o' && velha[1, 0] == 'o' && velha[2, 0] == 'o' ||
                    velha[0, 0] == 'o' && velha[1, 1] == 'o' && velha[2, 2] == 'o' ||
                    velha[0, 1] == 'o' && velha[1, 1] == 'o' && velha[2, 1] == 'o' ||
                    velha[0, 2] == 'o' && velha[1, 2] == 'o' && velha[2, 2] == 'o' ||
                    velha[0, 2] == 'o' && velha[1, 1] == 'o' && velha[2, 0] == 'o' ||
                    velha[1, 0] == 'o' && velha[1, 1] == 'o' && velha[1, 2] == 'o' ||
                    velha[2, 0] == 'o' && velha[2, 1] == 'o' && velha[2, 2] == 'o')
                {
                    Console.WriteLine("Jogador 2 venceu!");
                    result = false;
                }
                // Verifica empate
                else if (char.IsLetter(velha[0, 0]) && char.IsLetter(velha[0, 1]) && char.IsLetter(velha[0, 2]) &&
                    char.IsLetter(velha[1, 0]) && char.IsLetter(velha[1, 1]) && char.IsLetter(velha[1, 2]) &&
                    char.IsLetter(velha[2, 0]) && char.IsLetter(velha[2, 1]) && char.IsLetter(velha[2, 2]))
                {
                    Console.WriteLine("Empate!");
                    result = false;
                }
                
            }
            Console.WriteLine("GAME OVER");
            Console.ReadKey();
        }
    }
}