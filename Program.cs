// <copyright file="Programs.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
namespace JUnitTesting_Programs
{
    using System;
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\n\nJUnitTesting Programs: \n\t1.Vending Machine\n\t2.Gregorian calendar\n\t3.Temperature Conversion\n\t4.Calculate Monthly Payment\n\t5.Find SquareRoot Using Newtons Method\n\t6.Decimal To Binary\n\t7.BinaryToDecimal Swap Nibbles\n\t8.exit\n\n");
                    Console.Write("Enter Your Choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            VendingMachine vendmachine = new VendingMachine();
                            vendmachine.FindNoOfNotesForChange();
                            break;
                        case 2:
                            Gregorian_calendar calendar = new Gregorian_calendar();
                            calendar.FindDayOfWeek();
                            break;
                        case 3:
                            TemperatureConversion temp = new TemperatureConversion();
                            temp.FindTemperature();
                            break;
                        case 4:
                            MonthlyPayment monthpay = new MonthlyPayment();
                            monthpay.CalculatePayment();
                            break;
                        case 5:
                            SquareRootUsingNewtonsMethod sqrt = new SquareRootUsingNewtonsMethod();
                            sqrt.FindSqrtUsingNewtonsMethod();
                            break;
                        case 6:
                            DecimalToBinary dectobin = new DecimalToBinary();
                            dectobin.ConvertDecimalTobinary();
                            break;
                        case 7:
                            BinaryToDecimalSwapNibble bitodec = new BinaryToDecimalSwapNibble();
                           //// bitodec.SwapNibble();
                            break;
                        case 8:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid Input Enter Choice Between 1 To 7");
                }
            }
        }
    
    }
}
