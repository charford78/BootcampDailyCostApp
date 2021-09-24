using System;

namespace BootcampDailyCostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var BootcampCost = 15500m;
            var BootcampDays = 65;

            Console.WriteLine($"Each day of Bootcamp costs ${BootcampCost / BootcampDays}.");
            Console.WriteLine("So try not to miss any days.");
        }
    }
}
