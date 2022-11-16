using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class SquareRoot
    {
        public int Number;

        public SquareRoot(int number)
        {
            Number = number;
        }
        public static SquareRoot UserInputForSquareRoot()
        {
            Console.WriteLine("Enter a Positive Number to Find Square root of it : ");
            int sq = Convert.ToInt32(Console.ReadLine());

            return new SquareRoot(sq)
            {
                Number = sq
            };
        }
        public void CalculateSquareRoot()
        {
            double SqrtNumber = Math.Sqrt(Number);

            Console.WriteLine("Square Root of " + Number + " is : " + (Math.Round(SqrtNumber, 4)));
        }
    }
}
