using System;
namespace VendingMachine.Services
{
    public class CalculationService
    {

        // PER SESSION. 
        public double Add(double amount,double amount2)
        {
            return amount + amount2;
        }


        public double Subtract(double amount, double amount2)
        {
            return amount - amount2;
        }


    }
}
