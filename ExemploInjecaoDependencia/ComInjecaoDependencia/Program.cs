using ExemploInjecaoDependencia.Controllers;
using ExemploInjecaoDependencia.Services;
using System;

namespace ExemploInjecaoDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new RecepcaoController(new RecepcaoService());
            string resultado = controller.Ola("Peakles");
            Console.WriteLine(resultado);
        }
    }
}