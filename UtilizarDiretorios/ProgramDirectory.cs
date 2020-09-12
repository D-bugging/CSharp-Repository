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
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}