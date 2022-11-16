using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class UserInput
    {
        // Vending Machine 
        public void vendingMachineProblem()
        {
            var vm = VendingMachine.UserInputForVendingMachine();
            VendingMachine machine = new VendingMachine(vm.Number);
            machine.calculateChange();
        }
        // Day Of Week 
        public void dayOfWeekProblem()
        {
            var w = DayOfWeek.UserInputForDayOfWeek();
            DayOfWeek week = new DayOfWeek(w.Date, w.Month, w.Year);
            week.FindDayOfWeek();
        }
        // Temperature Conversion 
        public void temperatureConversionProblem()
        {
            var tm = TemperatureConversion.UserInputForTemperature();
            TemperatureConversion temperature = new TemperatureConversion(tm.Option);
            temperature.TemperatureConversionCalculation();
        }
        // Monthly Payment 
        public void MonthlyPaymentProblem()
        {
            var mp = MonthlyPayment.UserInputForMonthlyPayment();
            MonthlyPayment payment = new MonthlyPayment(mp.Principal, mp.InterestRate, mp.Year);
            payment.CalculateMonthlyPayment();
        }
        // Square Root Of Number 
        public void SquareRootProblem()
        {
            var sq = SquareRoot.UserInputForSquareRoot();
            SquareRoot root = new SquareRoot(sq.Number);
            root.CalculateSquareRoot();
        }
        // Decimal To Binary Coversion 
        public void DecimalToBinaryConversionProblem()
        {
            var db = DecimalToBinaryConversion.UserInputForDecimalToBinary();
            DecimalToBinaryConversion binary = new DecimalToBinaryConversion(db.DNumber);
            binary.ConvertDecimalToBinary();
        }
        // Integer to Binary Conversion 
        public void IntegerToBinaryConversionProblem()
        {
            var ib = IntegerToBinaryConversion.UserInputForIntegerToBinary();
            IntegerToBinaryConversion bin = new IntegerToBinaryConversion(ib.IntNumber);
            bin.ConvertIntegerToBinary();
        }
    }
}
