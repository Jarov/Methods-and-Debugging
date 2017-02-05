using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.MaxMethod
{
    class Program
    {
        static int greater;

        static void GetMax(int a, int b)
        {
            greater = Math.Max(a, b);
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            GetMax(firstNumber, secondNumber);
            GetMax(greater, thirdNumber);
            Console.WriteLine(greater);
        }
    }
}
