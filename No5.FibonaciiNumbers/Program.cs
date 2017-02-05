using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.FibonaciiNumbers
{
    class Program
    {
        static void Fibonachi(int number)
        {
            int first = 0;
            int second = 1;
            int fib = 0;

            for (int i = 0; i <= number; i++)
            {
                if (i == 0 || i == 1)
                {
                    fib = 1;
                    first = 1;
                    second = 1;
                }
                else
                {
                    fib = first + second;
                    first = second;
                    second = fib;
                }
            }
            Console.WriteLine(fib);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fibonachi(n);
        }
    }
}
