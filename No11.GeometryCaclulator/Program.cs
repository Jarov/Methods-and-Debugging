using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No11.GeometryCaclulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            if (figure == "triangle")
                Console.WriteLine(Triangle().ToString("0.00"));
            if (figure == "square")
                Console.WriteLine(Square().ToString("0.00"));
            if (figure == "rectangle")
                Console.WriteLine(Rectanle().ToString("0.00"));
            if (figure == "circle")
                Console.WriteLine(Circle().ToString("0.00"));
        }

        static double Triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return (side*height)/2;
        }
        static double Square()
        {
            double side = double.Parse(Console.ReadLine());

            return side * side;
        }
        static double Rectanle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return width * height;
        }
        static double Circle()
        {
            double radius = double.Parse(Console.ReadLine());

            return Math.PI * radius * radius;
        }
    }
}
