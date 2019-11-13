// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Basic_Programs
{
    using System;
    /// <summary>
    /// This Class for Find Nth Harmonic Number
    /// </summary>
    class HarmonicNumber
    {
        
            /// Finds the  Nth harmonic No.
             public void FindHarmonic()
            {
                Utility u = new Utility();
                ///Read The Harmonic No.
                Console.Write("Enter N th Harmonic No : ");
                double h_no = Convert.ToDouble(Console.ReadLine());
                ///Validate that read number must be not zero
                if(h_no!=0)
                {
                    Console.WriteLine("Harmonic No :" + u.CalculateHarmonic(h_no));

                }
                else
                {
                    Console.WriteLine("Number Must Be Other Than Zero");
                }
             }
    }
}
