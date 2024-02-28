using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_C__05
{
    internal class Program
    {
        class MultiplicationTable
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Multiplication table of {0}:", number);

                // Loop to generate and display the table
                for (int i = 1; i <= 10; i++)
                {
                    int product = number * i;
                    Console.WriteLine("{0} x {1} = {2}", number, i, product);
                }
            }
        }
    }
}
