using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Created class PrimeNumber
    public class PrimeNumber
    {
        //Created prime numbers method
        public void PrimeNumbers()
        {
            //Taking user input
            Console.WriteLine("Please enter input number");
            int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=2; i<=input/2; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine("The number is not prime");
                    count=1;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("The number is prime");
            }
        }
    }
}
