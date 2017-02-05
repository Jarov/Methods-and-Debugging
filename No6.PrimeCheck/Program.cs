using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6.PrimeCheck
{
    class Program
    {
        static bool isPrime(long number)
        {
            bool prime = false;
            if (number == 0 || number == 1) prime = false;
            for (long i = 2; i <= (int)Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number % i == 0 && i != number)
                {
                    prime = false;
                    break;
                }
                else
                {
                    prime = true;
                }
            }
            return prime;
        }

        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
    }
}
