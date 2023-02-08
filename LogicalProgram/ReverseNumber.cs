using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Created class ReverseNumber
    public class ReverseNumber
    {
        //Created method ReverseNumbers
        public void ReverseNumbers()
        {
            int remiainder, rev = 0;
            Console.WriteLine("Enter input number");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;
            while(input != 0)
            {
                remiainder = input % 10;
                rev = rev * 10 + remiainder;
                input = input / 10;
            }
            Console.WriteLine("The reverse number is:" + rev);
        }
    }
}
