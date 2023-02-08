using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Created class monthly payment 
    public class MonthlyPayments
    {
        //Created method monthly payment 
        public static void MonthlyPayment()
        {
            Console.WriteLine("Enter principle loan amount");       //Taking user input
            double P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of Interest");
            double R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Years to pay off");
            double y = Convert.ToInt32(Console.ReadLine());

            double n = 12 * y;
            double r = R / (12 * 100);
            double Payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly payment is:" + Payment);
        }
    }
}
