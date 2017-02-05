using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No9.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());

            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());

            if (LineLength(firstLineX1, firstLineY1, firstLineX2, firstLineY2) >= LineLength(secondLineX1, secondLineY1, secondLineX2, secondLineY2))
            {
                closerDot(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            }
            else
            {
                closerDot(secondLineX1, secondLineY1, secondLineX2, secondLineY2);
            }
        }

        static double LineLength(double x1, double y1, double x2, double y2)
        {
            double length = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            return length;
        }
        static void closerDot(double x1, double y1, double x2, double y2)
        {
            double firstDiagonal = x1 * x1 + y1 * y1;
            double secondDiagonal = x2 * x2 + y2 * y2;

            if (firstDiagonal <= secondDiagonal)
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            else
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }
}
