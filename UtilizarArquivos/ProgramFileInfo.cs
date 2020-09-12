using System;
using System.IO;

namespace ExemploArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\D-bugging\Desktop\arquivoTeste.txt";
            string targetPath = @"C:\Users\D-bugging\Desktop\arquivoTeste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // Instanciar o objeto do tipo FileInfo
                //fileInfo.CopyTo(targetPath); // Copiar texto para outro arquivo

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("Total de linhas: " + lines.Length);
            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}