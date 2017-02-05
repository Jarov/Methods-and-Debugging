using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.CenterPodouble
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            closerDot(x1, y1, x2, y2);
        }
        
        static void closerDot(double x1, double y1, double x2, double y2)
        {
            double firstDiagonal = x1 * x1 + y1 * y1;
            double secondDiagonal = x2 * x2 + y2 * y2;

            if (firstDiagonal <= secondDiagonal)
                Console.WriteLine($"({x1}, {y1})");
            else
                Console.WriteLine($"({x2}, {y2})");
        }
    }
}
