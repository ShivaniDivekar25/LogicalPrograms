using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Created class Temperature Converter 
    public class TemperatureConvertor
    {
        //Method created to convert celcius to fahrenhiet
        public static double celciusToFahrenhiet()
        {
            Console.WriteLine("Enter temperature in celcius");
            double Celcius = Convert.ToDouble(Console.ReadLine());
            double Fahrenhiet = (Celcius * 9 / 5) + 3;
            Console.WriteLine("The {0} celcius is converted into {1} fahrenhiet",Celcius,Fahrenhiet);
            return Fahrenhiet;
        }
        //Created method to convert fahrenhiet to celcius
        public static double fahrenhietToCelcius()
        {
            Console.WriteLine("Enter temperature in fahrenhiet");
            double Fahrenhiet = Convert.ToDouble(Console.ReadLine());
            double Celcius = (Fahrenhiet - 32) * 5 / 9;
            Console.WriteLine("The {0} fahrenhiet is converted into {1} celcius",Fahrenhiet,Celcius);
            return Celcius;
        }
    }
}
