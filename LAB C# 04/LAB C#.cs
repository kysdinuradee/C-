using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_C__04
{
    internal class Program
    {
        class FibonacciSeries
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the number of terms (N): ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Fibonacci Series: ");
                PrintFibonacci(n);
                Console.WriteLine();
            }

            static void PrintFibonacci(int n)
            {
                if (n == 0)
                {
                    return; // Base case: Stop recursion if N is 0
                }

                // Print first two terms outside recursion for initial values
                if (n >= 2)
                {
                    Console.Write("0 1 ");
                }
                else
                {
                    Console.Write(n + " "); // Handle first two cases (N = 1 or 2) separately
                }

                PrintFibonacciRecursive(0, 1, 2, n);
            }

            static void PrintFibonacciRecursive(int first, int second, int counter, int n)
            {
                if (counter > n)
                {
                    return; // Base case: Stop recursion when N terms are printed
                }

                int next = first + second;
                Console.Write(next + " ");

                PrintFibonacciRecursive(second, next, counter + 1, n); // Recursive call with updated values
            }
        }
    }
}
