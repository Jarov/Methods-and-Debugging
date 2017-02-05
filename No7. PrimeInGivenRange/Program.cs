using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No7.PrimeInGivenRange
{
    class Program
    {
        static bool isPrime(long number)
        {
            bool prime = false;
            if (number == 0 || number == 1) prime = false;
            for (int i = 2; i <= (int)Math.Ceiling(Math.Sqrt(number)); i++)
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

        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            
            List<int> Numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (isPrime(i))
                {
                    Numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(", ", Numbers));
        }
    }
}
