using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public void PerfectNumbers()
        {
            int sum = 0;
            Console.WriteLine("Enter user input");
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<input; i++)
            {
                if (input % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum == input)
            {
                Console.WriteLine("{0} is perfect number",input);
            }
            else
            {
                Console.WriteLine("{0} is not perfect number",input);
            }
        }
    }
}
