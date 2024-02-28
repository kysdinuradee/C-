using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_C__01
{
    static void Main(string[] args)
    {
        // Prompt the user for the length and width
        Console.WriteLine("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calculate the area using a separate function
        double area = CalculateArea(length, width);

        // Display the calculated area
        Console.WriteLine($"The area of the rectangle is: {area}");
    }

    static double CalculateArea(double length, double width)
    {
        return length * width;
    }
}
