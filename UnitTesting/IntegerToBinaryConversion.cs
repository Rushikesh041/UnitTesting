using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class IntegerToBinaryConversion
    {
        public int IntNumber;

        public IntegerToBinaryConversion(int intNumber)
        {
            IntNumber = intNumber;
        }
        public static IntegerToBinaryConversion UserInputForIntegerToBinary()
        {
            Console.WriteLine("Enter Integer Number : ");
            int i = Convert.ToInt32(Console.ReadLine());

            return new IntegerToBinaryConversion(i)
            {
                IntNumber = i,
            };
        }
        public void ConvertIntegerToBinary()
        {
            int result = ((IntNumber & 0x0F) << 4 | (IntNumber & 0xF0) >> 4);

            Console.WriteLine("Decimal Number By Swapping Nibble is : " + result);
            if (result == 0)
            {
                Console.WriteLine("The Number is Not the Power of 2");
            }
            while (result != 1)
            {

                if (result % 2 != 0)
                {
                    Console.WriteLine("The Number is Not the Power of 2");
                    break;
                }

                result = result / 2;
            }
            if (result == 1)
            {
                Console.WriteLine("The Number is the Power of 2");
            }
        }
    }
}
