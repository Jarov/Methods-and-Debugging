using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace No14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 2; i <= Number; i++)
            {
                factorial *= i;
            }

            int count = 0;
            while (factorial % 10 == 0)
            {
                factorial /= 10;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
