using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class MonthlyPayment
    {
        public int Principal, Year;
        public double InterestRate;

        public MonthlyPayment(int principal, double interestRate, int year)
        {
            Principal = principal;
            InterestRate = interestRate;
            Year = year;
        }
        public static MonthlyPayment UserInputForMonthlyPayment()
        {
            Console.Write("Enter the Loan Amount : ");
            int pr = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Interest Rate : ");
            int rt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Duration of in Years : ");
            int t = Convert.ToInt32(Console.ReadLine());

            return new MonthlyPayment(pr, rt, t)
            {
                Principal = pr,
                InterestRate = rt,
                Year = t
            };
        }
        public void CalculateMonthlyPayment()
        {
            int Month = 12 * Year;
            double rate = InterestRate / (12 * 100);
            double payment = (Principal * rate) / (1 - Math.Pow((1 + rate), -Month));

            Console.WriteLine("Monthly EMI is : " + (Math.Round(payment, 2)));

        }
    }
}
