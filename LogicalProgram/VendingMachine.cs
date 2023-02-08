using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    //Created class Vending machine
    public class VendingMachine
    {
        //Created method countCurrency
        public static void countCurrency()
        {
            Console.WriteLine("Enter an amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notesCounter = new int[8];
            
            for(int i=0; i<8; i++)
            {
                if (amount >= notes[i])
                {
                    notesCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                } 
            }
            for(int i=0; i<8; i++)
            {
                if (notesCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + ":" + notesCounter[i]);
                }
            }
        }
    }
}
