using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___LAB_S2_Q3
{
    class TemperatureTracker
    {
        private double[] temperatures; // Array to store daily temperatures

        public TemperatureTracker(int days)
        {
            temperatures = new double[days]; // Initialize the array with the specified size
        }

        public void InputTemperatures()
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                temperatures[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void DisplayTemperatures()
        {
            Console.WriteLine("\nWeekly Temperature Report:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int days = 7; // Number of days in a week

            // Create a TemperatureTracker object
            TemperatureTracker tracker = new TemperatureTracker(days);

            Console.WriteLine("Enter the daily temperatures: ");
            tracker.InputTemperatures();

            tracker.DisplayTemperatures();
        }
    }
}
