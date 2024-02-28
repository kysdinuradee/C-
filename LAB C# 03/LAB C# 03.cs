using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_C__03
{
    internal class Program
    {
        class SumOfNumbers
        {
            static void Main(string[] args)
            {
                int number;

                // Loop to ensure positive input
                do
                {
                    Console.Write("Enter a positive integer: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number < 0)
                    {
                        Console.WriteLine("ERROR: Invalid input. Please enter a positive integer.");
                    }
                } while (number < 0);

                // Calculate and display the sum
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"The sum of all numbers from 1 to {number} is: {sum}");
            }
        }
    }
}
