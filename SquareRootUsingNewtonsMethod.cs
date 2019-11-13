// <copyright file="SquareRootUsingNewtonsMethod.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
namespace JUnitTesting_Programs
{
    using System;
    class SquareRootUsingNewtonsMethod
    {
        /// <summary>
        /// Finds the SQRT using newtons method.
        /// </summary>
        public void FindSqrtUsingNewtonsMethod()
        {
            Console.Write("\nEnter NonNegative Value To Compute SquareRoot Using Newton's Method: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            Console.Write("\nSquareRoot After Proper Precision:  " + Utility.CalculateSqrtUsingNewtonsMethod(c,t,epsilon));

        }
    }
}
