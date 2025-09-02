using System;

namespace PalkkaLaskin
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

			Console.Write("Enter your hourly wage: ");

            string? userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("No user input");
                return;
            }

            float hourlyWage = float.Parse(userInput);

            // calculate the wage per second and print it
            float wagePerSecond = hourlyWage / 3600;
            float totalWage = 0;

			while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    break;
                }

                Console.WriteLine($"Total wage: {Math.Round(totalWage, 2)}€");
                totalWage = totalWage + wagePerSecond;
                Thread.Sleep(1000);
            }
        }
    }
}