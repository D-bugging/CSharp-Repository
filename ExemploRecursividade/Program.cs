using System;
using System.IO;

namespace ExemploRecursividade
{
  class Program
  {
    public static void LerArquivo(int numeroArquivo)
    {
      string caminho = @"C:\Users\D-bugging\Desktop\TEMP\DIR\file" + numeroArquivo + ".txt";
      if (File.Exists(caminho))
      {
        using (StreamReader arquivo = File.OpenText(caminho))
        {
          string linha;
          while ((linha = arquivo.ReadLine()) != null)
          {
            Console.WriteLine(linha);
          }
        }
      }

      string arquivos = @"C:\Users\D-bugging\Desktop\TEMP\DIR\file" + (numeroArquivo + 1) + ".txt";
      if (File.Exists(arquivos))
      {
        LerArquivo(numeroArquivo + 1);
      }
    }
    static void Main(string[] args)
    {
      LerArquivo(1);
    }
  }
}