namespace ExemploDelegate
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }

        // Não funciona com Delegate, pois deve ser declarado com 2 double e retornado um valor em double
        public static double Square(double x)
        {
            return x * x;
        }
    }
}