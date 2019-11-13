// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Basic_Programs
{
    using System;
    /// Finds The Leap Year
    class LeapYear
    {
        //This method Reads the Year 
        public void FindLeapYear()
        {
            Utility u = new Utility();
            Console.Write("Enter Year Which You want To Check:");
            int year =Convert.ToInt16(Console.ReadLine());
            Utility.FindLeapYear(year);
        }
    }
}
