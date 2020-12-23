using System;

namespace U3_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            double a = 2.5;
            char c = 'a';

            Console.WriteLine("Valor de n: {0}", n);
            Console.WriteLine("Valor de a: {0}", a);
            Console.WriteLine("Valor de c: {0}", c);

            Console.WriteLine("Valor de n+a: {0}", n + a);
            Console.WriteLine("Valor de a-n: {0}", a - n);

            Console.WriteLine("Valor numerico de c: {0}", Char.GetNumericValue(c));

            Console.ReadKey();
        }
    }
}
