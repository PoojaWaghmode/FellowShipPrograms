// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace JUnitTesting_Programs
{
    using System;
    class Utility
    {
        /// <summary>
        /// Calculates the notes.
        /// </summary>
        /// <param name="Notes">The notes.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="size">The size.</param>
        public static void CalculateNotes(int[] Notes,int amount,int size)
        {
            int[] NotesCounter= new int[size];
            int countnote = 0;
            for (int i =0; i<size; i++)
            {
                if(amount >= Notes[i])
                {
                    NotesCounter[i]=amount/ Notes[i];
                    countnote = countnote + NotesCounter[i];
                    amount = amount - NotesCounter[i] * Notes[i];
                }
                
            }
            for (int i =0; i<size; i++)
            {
                if (NotesCounter[i] != 0)
                {
                    Console.WriteLine("Note :  " + Notes[i] + ":" + NotesCounter[i]);
                }
            }
            Console.WriteLine("Total No. Of Notes " + countnote);
        }
        /// <summary>
        /// Calculates the calendar.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        public static void CalculateCalendar(int day,int month,int year)
        {
               int Y0 = year - (14 - month) / 12;
                Console.Write("\n Y0: " + Y0);
                int x = Y0 + Y0 / 4 - Y0 / 100 + Y0 / 400;
                Console.Write("\nX: " + x);
                int M0 = month + 12 * ((14 - month) / 12) - 2;
                Console.Write("\nM0: " + M0);
                int D0 = (day + x + 31 * M0 / 12) % 7;
                Console.Write("\nD0: " + D0);

                switch (D0)
                {
                    case 0:
                        Console.WriteLine("Day Is Sunday");
                        break;

                    case 1:
                        Console.WriteLine("Day Is Monday");
                        break;
                    case 2:
                        Console.WriteLine("Day Is Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Day Is Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Day Is Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Day Is Friday");
                        break;
                    case 6:
                        Console.WriteLine("Day Is Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
        }
        /// <summary>
        /// Converts the cel to farehnite.
        /// </summary>
        /// <param name="Celtemp">The celtemp.</param>
        public static void ConvertCelToFarehnite(double Celtemp)
        {
            double farehnitetemp = (Celtemp * 9 / 5) + 32;
            Console.Write("Temperature In Farehnite:" + farehnitetemp);
        }
        /// <summary>
        /// Converts the farehnite to cel.
        /// </summary>
        /// <param name="farehnitetemp">The farehnitetemp.</param>
        public static void ConvertFarehniteToCel(double farehnitetemp)
        {
            double celciusTemp= (farehnitetemp - 32) * 5 / 9;
            Console.Write("Temperature In Celcius:" + celciusTemp);
        }
        /// <summary>
        /// Calculates the month payment.
        /// </summary>
        /// <param name="principal_loan_amt">The principal loan amt.</param>
        /// <param name="num_year">The number year.</param>
        /// <param name="rate">The rate.</param>
        /// <param name="n">The n.</param>
        /// <param name="r">The r.</param>
        /// <returns></returns>
        public static double CalculateMonthPayment(double principal_loan_amt,double num_year,double rate,double n,double r)
        {
            double MonthPayment= (principal_loan_amt*r)/1-Math.Pow((1+r),(-n));
            return MonthPayment;
        }
        /// <summary>
        /// Calculates the SQRT using newtons method.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="t">The t.</param>
        /// <param name="epsilon">The epsilon.</param>
        /// <returns></returns>
        public static double CalculateSqrtUsingNewtonsMethod(double c,double t,double epsilon)
        {
            while(Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;
        }
        /// <summary>
        /// Calculates the decimal to binary.
        /// </summary>
        /// <param name="decimal_no">The decimal no.</param>
        public static int[] CalculateDecimalToBinary(int decimal_no)
        {
           int[] binary = new int[10000];
           int i;
           int count = 0;
            Console.Write("Binary Number Of " + decimal_no + " Is :  ");
            for (i=0;decimal_no>0;i++)
            {
                binary[i]= decimal_no % 2;
                decimal_no = decimal_no / 2;
            } 
            for (i = i - 1; i >=0; i--)
            {
                Console.Write(" " + binary[i]);
            }
            return binary;
        }
        public static void ReadIntArray(int[] arr,int length)
        {
            
            for (int i = 0; i <arr.Length; i++)
            {
                Console.Write("element - {0} : ", i);
               arr[i] =Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void PrintIntArray(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("element - {0} : ", arr[i]);
                
            }
        }


    }
}
