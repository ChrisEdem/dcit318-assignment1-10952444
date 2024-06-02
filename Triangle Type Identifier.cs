using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            int side1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side 2: ");
            int side2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side 3: ");
            int side3 = Convert.ToInt32(Console.ReadLine());

            string triangleType;
            if (side1 == side2 && side2 == side3)
            {
                triangleType = "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                triangleType = "Isosceles";
            }
            else
            {
                triangleType = "Scalene";
            }

            Console.WriteLine($"The triangle is: {triangleType}");
        }
    }
}


