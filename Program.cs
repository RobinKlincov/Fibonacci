using System;

namespace Fibonacci2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            Console.Write("Enter any number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("{0} {1}", a, b);


            for (int i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}
