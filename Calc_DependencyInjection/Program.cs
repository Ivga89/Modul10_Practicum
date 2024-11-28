using System.Runtime.CompilerServices;

namespace Calc_DependencyInjection
{
    class Program
    {
        static ILogger? Logger { get; set; }

        private static void Main(string[] args)
        {
            Logger = new Logger();

            ICalculator calculator = new Calculator(Logger);

            try
            {
                Console.WriteLine("Enter first number");
                float value1 = float.Parse(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("Enter second number");
                float value2 = float.Parse(Console.ReadLine() ?? string.Empty);

                float result = calculator.Addition(value1, value2);

                Console.WriteLine($"Sum of numbers {value1} and {value2} = {result}");
            }
            catch (Exception e)
            {
                Logger?.Error(e.ToString());
            }
        }
    }
}