using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            if (parameter == "area")
                Console.WriteLine(Area(side).ToString("0.00"));
            if (parameter == "face")
                Console.WriteLine(Face(side).ToString("0.00"));
            if (parameter == "space")
                Console.WriteLine(Space(side).ToString("0.00"));
            if (parameter == "volume")
                Console.WriteLine(Volume(side).ToString("0.00"));
        }

        static double Area(double side)
        {
            return 6 * (side * side);
        }
        static double Volume(double side)
        {
            return side * side * side;
        }
        static double Space(double side)
        {
            return Math.Sqrt(3 * (side * side));
        }
        static double Face(double side)
        {
            return Math.Sqrt(2 * (side * side));
        }
    }
}
