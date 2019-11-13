// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Basic_Programs
{
    using System;
    class Utility
    {
        /// <summary>
        /// Replaces the template.
        /// </summary>
        /// <param name="str">The string.</param>
        public static void ReplaceTemplate(string str)
        {
            Console.Write("Enter Username You Want To Replace: ");
            String username = Console.ReadLine();
            ///Validate that replace string must be greater than 3
            if (username.Length>3)
            {
                String s2 = str.Replace("<<Username>>",username);
                Console.WriteLine(s2);
            }
            else
            {
                Console.WriteLine("Username Must Be Greater Than Three ");
            }
           
        }
        /// <summary>
        /// Flips the coin.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns></returns>
        public int FlipCoin(int num)
        {
            double head = 0, tail = 0;
            for (int i=0;i<num;i++)
            {
                /// Uses Random Class to take input randomly
                Random r = new Random();
                Double randno = Convert.ToDouble(r.NextDouble());
                if(randno<0.5)
                {
                    head++;

                }
                else
                {
                    tail++;
                }
            }
            Console.WriteLine("No. Of Heads: "+head+"\nNo. Of Tails:  "+tail+"\nPercentage Of Head :"+head/num*100+"\nPercentage Of Tails :"+tail/num*100);
            return num;
        }
        /// <summary>
        /// Finds the leap year.
        /// </summary>
        /// <param name="year">The year.</param>
        public static void FindLeapYear(int year)
        {
            int digit = 0;
            int temp = year;
            ///check the entered year must be 4 digit
            while (temp > 0)
            {
                temp = temp / 10;
                digit++;
            }
            if(digit==4)
            {
                if(year%400==0 || year % 4 == 0 && year %100!=0)
                {
                    Console.WriteLine(year+" Year Is Leap Year");
                }
                else
                {
                    Console.WriteLine(year+" Year Is Not Leap Year");
                }
            }
            else
            {
                Console.WriteLine(" Year Must Be 4 Digit");
            }
           
        }
        /// <summary>
        /// Calculates the harmonic.
        /// </summary>
        /// <param name="h_no">The h no.</param>
        /// <returns></returns>
        public double CalculateHarmonic(double h_no)
        {
            double sum=0;
            ///Harmonic series starts from 1+1/2+1/3+....so there denominator goes from 1 to that harmonic number
            for (int i=1;i<=h_no;i++)
            {
                sum=sum+ 1.0 / i;
            }
            return sum;
        }
        /// <summary>
        /// Finds the power of two.
        /// </summary>
        /// <param name="power">The power.</param>
        public static void FindPowerOfTwo(int power)
        {
            int result = 0;
            for(int i = 0; i <=power; i++)
            {
                 result =(int) Math.Pow(2, i);
                 Console.WriteLine(" "+result);
            }
            
        }
        /// <summary>
        /// Finds the factors.
        /// </summary>
        /// <param name="num">The number.</param>
        public static void FindFactors(int num)
        {
            int temp = num;
            for (int i=2;i*i<=num;i++)
            {
                while(temp%i==0)
                {
                    Console.WriteLine(i);
                    temp= temp / i;
                }
            }
        }

        
    }
}
