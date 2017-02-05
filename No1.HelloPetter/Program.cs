using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.HelloPetter
{
    class Program
    {
        static void Print(string print)
        {
            Console.WriteLine($"Hello, {print}!");
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Print(name);
        }
    }
}
