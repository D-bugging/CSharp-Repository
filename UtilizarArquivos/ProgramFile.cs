using System;
using System.IO;

namespace ExemploArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\D-bugging\Desktop\arquivoTeste.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                /*
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                */
                sr = File.OpenText(path); // Implícito

                // Lê todas as linhas do arquivo
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine(); // Lê a primeira linha do arquivo
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}