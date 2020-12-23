using System;

namespace U3_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine("Suma: {0}", a + b);
            Console.WriteLine("Resta: {0}", a - b);
            Console.WriteLine("Multuplicación: {0}", a * b);
            Console.WriteLine("División: {0}", a / b);
            Console.WriteLine("Módulo: {0}", a % b);

            Console.ReadKey();
        }
    }
}
