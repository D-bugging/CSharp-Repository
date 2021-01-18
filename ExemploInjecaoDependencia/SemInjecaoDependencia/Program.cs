using ExemploSemInjecaoDependencia.Controllers;
using System;

namespace ExemploSemInjecaoDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new RecepcaoController();
            string resultado = controller.Ola("Peakles");
            Console.WriteLine(resultado);
        }
    }
}