using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class TemperatureConversion
    {
        public int Option;

        public TemperatureConversion(int option)
        {
            Option = option;
        }
        public static TemperatureConversion UserInputForTemperature()
        {
            Console.WriteLine("Enter 1 to Convert Temparature Celcius to Fahrenheit \nEnter 2 to Convert Temparature Fahrenheit to Celcius");
            int op = Convert.ToInt32(Console.ReadLine());

            return new TemperatureConversion(op)
            {
                Option = op
            };
        }
        public void TemperatureConversionCalculation()
        {
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Enter the Temparature in Celcius: ");
                    int celcius = Convert.ToInt32(Console.ReadLine());
                    int result = (celcius * 9 / 5) + 32;
                    Console.WriteLine("Temperature Celcius to Fahrenheit is : " + result);
                    break;
                case 2:
                    Console.WriteLine("Enter the Temparature in Fahrenheit: ");
                    int Fahrenheit = Convert.ToInt32(Console.ReadLine());
                    int result2 = (Fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Temperature Fahrenheit to Celcius is : " + result2);
                    break;

            }
        }

    }
}
