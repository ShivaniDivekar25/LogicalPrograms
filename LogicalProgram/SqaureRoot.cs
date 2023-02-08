using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Created class square root
    public class SqaureRoot
    {
        //Created method to find square root
        public static void SquareRootNewtons()
        {
            Console.WriteLine("Enter the input value");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            while(Math.Abs(t-c/t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine("The square root of number is: " + t);
        }
    }
}
