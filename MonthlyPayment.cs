// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
namespace JUnitTesting_Programs
{
    using System;
    public class MonthlyPayment
        {
            public void CalculatePayment()
            {
                Console.WriteLine("Enter Principal Loan Amount: ");
                double principal_loan_amt = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter No. Of Years: ");
                double Num_year = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter Rate OF Interest:");
                double Rate_Of_Interest = Convert.ToDouble(Console.ReadLine());
                double n = 12 * Num_year;
                double r= Rate_Of_Interest / 12 * 100;
                Console.WriteLine("Monthly Payment: " + Utility.CalculateMonthPayment(principal_loan_amt,Num_year,Rate_Of_Interest, n, r));
            
            }
    }
}
