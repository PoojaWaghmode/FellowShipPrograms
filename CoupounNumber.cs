// <copyright file="CouponNumber.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Logical_Programs
{
    using System;

    /// <summary>
    /// Generate Coupon Number
    /// </summary>
    public class CouponNumber
    {
        /// <summary>
        /// Finds the  Unique coupon number.
        /// </summary>
        public void FindCoupounNumber()
        {
            ////keys string consist all numeric and alphanumeric values also special symbols
            String keys = "abcdegghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!~@#$%^&*()_+";
            ////Calculate Keys length 
            int len = keys.Length;
            Console.Write("\nLength Of Keys:" + len);
            ////Enter length of number of which u want to generate coupoun No.  
            Console.Write("\nEnter Distict No:");
            int distinct_no =Convert.ToInt32(Console.ReadLine());
            ////Return Coupoun Number is stored in char array so crate a new string and store char array in string
            Console.WriteLine("Coupoun No: "+ Utility.GetCopoun(keys, distinct_no));
        }
    }
}
