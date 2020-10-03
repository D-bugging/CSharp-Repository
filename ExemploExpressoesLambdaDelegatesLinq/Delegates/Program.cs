using System;

namespace ExemploDelegate
{

    delegate double BinaryNumericOperation(double n1, double n2); // Declaração do Delegate

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo Delegates
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            // BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum); <- Também é aceitável

            double result = op(a, b);
            // double result = op.Invoke(a, b); <- Opção alternativa
            Console.WriteLine(result);
        }
    }
}