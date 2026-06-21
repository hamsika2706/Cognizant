using System;

namespace FinancialForecast
{
    class Program
    {
        // Recursive method to calculate future value
        static double FutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

            return FutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Present Value: ");
            double presentValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Annual Growth Rate (in %): ");
            double growthRate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Enter Number of Years: ");
            int years = Convert.ToInt16(Console.ReadLine());

            double futureValue = FutureValue(presentValue, growthRate, years);

            Console.WriteLine("\nPredicted Future Value: " + futureValue);
        }
    }
}