// <copyright file="WindChill.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    class WindChill
    {
        /// <summary>
        /// Finds the wind chill.
        /// </summary>
        public void FindWindChill()
        {
            Utility u = new Utility();
            Console.Write("Enter Temperature In Farahnite:");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter Velocity Miles Per Hour:");
            double velocity = Convert.ToDouble(Console.ReadLine());
            ///Validate temp must be less than or equal to 50 and velocity must be less than 3 and greater than 120 
            if (temp <=50 && velocity < 3 || velocity > 120)
            {
                Console.WriteLine("Wind Chill: "+u.CalculateWindChill(temp, velocity));
            }
            else
            {
                Console.WriteLine("Enter Valid Inputs");
            }
        }
    }
}
