using System;
using System.IO;

namespace ExemploDiretorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\D-bugging\Desktop\DiretorioTeste";

            try
            {
                // Listar todos os sub-diretórios
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // *.* -> qualquer nome de arquivo com qualquer extensão
                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // Desta forma não precisa declarar IEnurable
                Console.WriteLine("FOLDERS:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                // Listar todos os arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                // Criar novo diretório
                Directory.CreateDirectory(path + @"\NovoDiretorio");

                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // Retorna o caminho/nome do diretório de um arquivo
                Console.WriteLine("GetDirectorySeparatorChar: " + Path.DirectorySeparatorChar); // Retorna o caractere separador, / ou \
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetFileName: " + Path.GetFileName(path)); // Retorna o nome do arquivo
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // Retorna o nome do arquivo sem extensão
                Console.WriteLine("GetExtension: " + Path.GetExtension(path)); // Retorna somente a extensão do arquivo
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); // Retorna todo o caminho até o arquvio
                Console.WriteLine("GetTempPath: " + Path.GetTempPath()); // Retorna o diretório temporário do sistema
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}