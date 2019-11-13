// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Basic_Programs
{
    using System;
    /// <summary>
    /// This class have multiple cases using switch for calls the particular class methods by creating boject of that class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {  
                    Console.WriteLine("\n\nBasic Programs: \n\t1.Replace String\n\t2.Flip Coin\n\t3.Leap Year\n\t4.PowerOfTwo\n\t5.Harmonic number\n\t6.Prime Factors\n\t7.exit\n\n");
                    Console.Write("Enter Your Choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                
                    switch (ch)
                    {
                        case 1:
                            StringReplace stringreplace= new StringReplace();
                            stringreplace.ReplaceString();
                            break;
                        case 2:
                            FlipCoin flipCoin = new FlipCoin();
                            flipCoin.CoinFlip();
                            break;
                        case 3:
                            LeapYear leapyear = new LeapYear();
                            leapyear.FindLeapYear();
                            break;
                        case 4:
                            PowerOfTwo poweroftwo = new PowerOfTwo();
                            poweroftwo.PrintPoweOfTwo();
                            break;
                        case 5:
                            HarmonicNumber harmonicno = new HarmonicNumber();
                            harmonicno.FindHarmonic();
                            break;
                        case 6:
                            PrimeFactorization primefactor = new PrimeFactorization();
                            primefactor.PrimeFactors();
                            break;
                        case 7:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                }
                catch (Exception )
                {
                    Console.WriteLine(" Invalid Input Enter Choice Between 1 To 7");
                }
            } 
        }
    }
}
