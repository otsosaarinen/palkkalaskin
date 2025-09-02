namespace PalkkaLaskin
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter your hourly pay: ");

            string? userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("No user input found");
                return;
            }

            float hourlyWage = float.Parse(userInput);

            float wagePerSecond = hourlyWage / 3600;
            float totalWage = 0;

            Console.WriteLine("\nPress Q to end the pay calculation\n");

            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    break;
                }

                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Write("UPDATE");
                Console.ResetColor();

                Console.Write(" ");

                DateTime currentTime = DateTime.Now;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{currentTime}");
                Console.ResetColor();

                Console.Write(" Total money: ");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{Math.Round(totalWage, 2)}€");
                Console.ResetColor();

                Console.WriteLine();

                totalWage = totalWage + wagePerSecond;

                Thread.Sleep(1000);
            }
        }
    }
}