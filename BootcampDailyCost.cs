using System;

namespace BootcampDailyCostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var BootcampCost = 15500m;
            var BootcampDays = 65;
            var PreMessage = "Each day of Bootcamp costs $";
            var PostMessage = ".";
            var Message = $"{PreMessage}{BootcampCost / BootcampDays}{PostMessage}";

            Console.WriteLine($"{Message}");
            Console.WriteLine("So try not to miss any days.");
            System.Diagnostics.Debug.WriteLine($"{Message}");
        }
    }
}
