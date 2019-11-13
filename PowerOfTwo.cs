// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Basic_Programs
{
    using System;
    /// <summary>
    /// This class Print Power Of Two
    /// </summary>
    public class PowerOfTwo
    {
        public void PrintPoweOfTwo()
        {
            Utility u = new Utility();
            ///Read the power
            Console.Write("\nEnter Power:");
            int power = Convert.ToInt16(Console.ReadLine());
            ///Validate that power should be greater than 0 and less than 31
            if (power>=0 && power < 31)
            {
                Console.Write("Table Of Power Of Two: ");
                Utility.FindPowerOfTwo(power);
            }
            ///If power is greater than 31 then int size overflows
            else
            {
                Console.WriteLine("Overflow");
            }

            
        }
    }
}
