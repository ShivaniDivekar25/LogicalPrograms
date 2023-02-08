namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            //Taking user input
            Console.WriteLine("Please enter option");
            Console.WriteLine("1:Fibonacci Series\n2:Prime Number\n3:Reverse Number\n4:Perfect Number\n5:Day of week");
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
                case 2:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.PrimeNumbers();
                    break;
                case 3:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.ReverseNumbers();
                    break;
                case 4:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.PerfectNumbers();
                    break;
                case 5:
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.DayOfWeeks();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}