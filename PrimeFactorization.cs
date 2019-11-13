// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeFactorization.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Basic_Programs
{
    using System;
    /// This Class Reads The No.to find the factors of it
    class PrimeFactorization
    {
        ///This method Reads the no. and then calls the FindFactor()method 
        public void PrimeFactors()
        {
            Utility u = new Utility();
            Console.Write("Enter Number To find factors Of It : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Factors Of "+n+" Is :");
            Utility.FindFactors(n);

        }


    }
}
