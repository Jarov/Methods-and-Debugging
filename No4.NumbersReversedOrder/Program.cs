using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.NumbersReversedOrder
{
    class Program
    {
        static void reverse(decimal inPut)
        {
            char[] digits = inPut.ToString().ToCharArray();
            for (int i = digits.Length; i > 0 ; i--)
            {
                Console.Write($"{digits[i-1]}");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            reverse(number);
        }
    }
}
