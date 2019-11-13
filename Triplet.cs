// <copyright file="Triplet.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    class Triplet
    {
        /// <summary>
        /// Searches the triplet.
        /// </summary>
        public void SearchTriplet()
        {
            Utility u = new Utility();
            Console.WriteLine("Enter The Size Of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.Write("Enter The Array Elements :");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
             Utility.FindSumZeroTriplet(a);
        }
    }
}
