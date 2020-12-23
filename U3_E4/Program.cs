using System;

namespace U3_E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 6;

            double n = 4.5;
            double m = 2.5;

            Console.WriteLine("Valores - x: {0} y: {1} n: {2} m: {3}");
            Console.WriteLine("Suma={0}", x + y);
            Console.WriteLine("Diferencia={0}", x - y);
            Console.WriteLine("Producto={0}", x * y);
            Console.WriteLine("Cociente={0}", x / y);
            Console.WriteLine("Resto={0}", x % y);

            Console.WriteLine("Suma={0}", n + m);
            Console.WriteLine("Diferencia={0}", n - m);
            Console.WriteLine("Producto={0}", n * m);
            Console.WriteLine("Cociente={0}", n / m);
            Console.WriteLine("Resto={0}", n % m);

            Console.WriteLine("Suma={0}", x + n);
            Console.WriteLine("Cociente={0}", y / m);
            Console.WriteLine("Resto={0}", y % m);

            Console.WriteLine("Suma={0}", x + y + n + m);
            Console.WriteLine("Producto={0}", x * y * n * m);

            Console.ReadKey();
        }
    }
}
