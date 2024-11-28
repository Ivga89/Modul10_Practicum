
namespace SimpleCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            try
            {
                Console.WriteLine("Enter first number");
                float value1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter first number");
                float value2 = float.Parse(Console.ReadLine());

                float result = calculator.Addition(value1, value2);

                Console.WriteLine($"Sum of numbers {value1} and {value2} = {result}");
            }

            catch(Exception e)
            {
                Console.Write(e.ToString());
            }
            
        }
    }
}

