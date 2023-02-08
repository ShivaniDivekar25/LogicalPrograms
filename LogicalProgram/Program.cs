namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            //Taking user input
            Console.WriteLine("Please enter option");
            Console.WriteLine("1:Fibonacci Series");
            int option = Convert.ToInt32(Console.ReadLine());
            //Switch case to call different method 
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter number");
                    int count = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci(count);
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}