// <copyright file="QuadraticEquation.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// -----------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    /// <summary>
    /// Finds The Quadratic Equation
    /// </summary>
    class QuadraticEquation
    {
        /// <summary>
        /// Finds the roots of Quadratic Equations.
        /// </summary>
        public void FindRoots()
        {
            Utility u = new Utility();
            Console.Write("Enter Value For A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Value For B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Value For C:");
            int c = Convert.ToInt32(Console.ReadLine());
            Utility.CalculateRoots(a,b,c);

        }
        
    }
}
