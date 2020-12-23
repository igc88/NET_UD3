using System;

namespace U3_E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 4;
            int d = 5;

            b = c;
            c = a;
            a = d;
            d = b;
        }
    }
}
