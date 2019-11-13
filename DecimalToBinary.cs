// <copyright file="DecimalToBinary.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
namespace JUnitTesting_Programs
{
    using System;
    class DecimalToBinary
    {
        /// <summary>
        /// Converts the decimal tobinary.
        /// </summary>
        public void ConvertDecimalTobinary()
        {
            Console.Write("Enter Decimal Number: ");
            int decimal_no = Convert.ToInt32(Console.ReadLine());
           
            ////Console.WriteLine("BinaryNo: " + );
            ////string a = null;
            ////for (int i = 0; i < binaryno.Length; i++)
            ////{
            ////    a = a + binaryno[i];
            ////}

            ////Console.WriteLine("BinaryString:" + a);
            ////while (a.Length % 4 != 0)
            ////{

            ////    a = 0 + a;
            ////}
            Console.WriteLine("Binary No:"+ Utility.CalculateDecimalToBinary(decimal_no));
        }
    }
}
