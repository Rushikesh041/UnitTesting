using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class VendingMachine
    {
        public int Number;

        public VendingMachine(int number)
        {
            Number = number;
        }
        public static VendingMachine UserInputForVendingMachine()
        {
            Console.WriteLine("Enter the Number of Rupess you want change of it : ");
            int n = Convert.ToInt32(Console.ReadLine());

            return new VendingMachine(n)
            {
                Number = n
            };
        }
        public void calculateChange()
        {
            int thousand = 0, fiveHundred = 0, hundred = 0, fifty = 0, ten = 0, five = 0, two = 0, one = 0;

            if (Number >= 1000)
            {
                while (Number >= 1000)
                {
                    Number = Number - 1000;
                    thousand++;
                }
                Console.WriteLine("You get " + thousand + " Number of 1000 Rs. Notes");
            }
            if (Number >= 500)
            {
                while (Number >= 500)
                {
                    Number = Number - 500;
                    fiveHundred++;
                }
                Console.WriteLine("You get " + fiveHundred + " Number of 500 Rs. Notes");
            }
            if (Number >= 100)
            {
                while (Number >= 100)
                {
                    Number = Number - 100;
                    hundred++;
                }
                Console.WriteLine("You get " + hundred + " Number of 100 Rs. Notes");
            }
            if (Number >= 50)
            {
                while (Number >= 50)
                {
                    Number = Number - 50;
                    fifty++;
                }
                Console.WriteLine("You get " + fifty + " Number of 50 Rs. Notes");
            }
            if (Number >= 10)
            {
                while (Number >= 10)
                {
                    Number = Number - 10;
                    ten++;
                }
                Console.WriteLine("You get " + ten + " Number of 10 Rs. Notes");
            }
            if (Number >= 5)
            {
                while (Number >= 5)
                {
                    Number = Number - 5;
                    five++;
                }
                Console.WriteLine("You get " + five + " Number of 5 Rs. Notes");
            }
            if (Number >= 2)
            {
                while (Number >= 2)
                {
                    Number = Number - 2;
                    two++;
                }
                Console.WriteLine("You get " + two + " Number of 2 Rs. Notes");
            }
            if (Number >= 1)
            {
                while (Number >= 1)
                {
                    Number = Number - 1;
                    one++;
                }
                Console.WriteLine("You get " + one + " Number of 1 Rs. Notes");
            }

        }
    }
}
