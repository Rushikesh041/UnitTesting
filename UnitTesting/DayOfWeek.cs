using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class DayOfWeek
    {
        public int Date, Month, Year;

        public DayOfWeek(int date, int month, int year)
        {
            Date = date;
            Month = month;
            Year = year;
        }
        public static DayOfWeek UserInputForDayOfWeek()
        {
            Console.Write("Enter Date : ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year : ");
            int y = Convert.ToInt32(Console.ReadLine());

            return new DayOfWeek(d, m, y)
            {
                Date = d,
                Month = m,
                Year = y
            };
        }
        public void FindDayOfWeek()
        {
            int x = 0, y0 = 0, m0 = 0, d0;

            y0 = Year - (14 - Month) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = Month + 12 * ((14 - Month) / 12) - 2;
            d0 = (Date + x + 31 * m0 / 12) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("Its Sunday");
                    break;
                case 1:
                    Console.WriteLine("Its Monday");
                    break;
                case 2:
                    Console.WriteLine("Its Thuesday");
                    break;
                case 3:
                    Console.WriteLine("Its Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Its Thursday");
                    break;
                case 5:
                    Console.WriteLine("Its Friday");
                    break;
                case 6:
                    Console.WriteLine("Its Saturday");
                    break;
            }

        }
    }
}
