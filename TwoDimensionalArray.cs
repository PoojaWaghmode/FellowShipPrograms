// <copyright file="TwoDimensionalArray.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    /// <summary>
    /// This class for Read Two Dimensional Integer,Double,Boolean array 
    /// </summary>
    public class TwoDimensionalArray
    {
        public void ReadWriteTwoDimensionalArray()
        {
            Utility u = new Utility();
            Console.Write("\nEnter No Of Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter No. Of Columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Values In Integer Array:");
            int[,] intarr = new int[rows, cols];
            Utility.ReadArray(intarr,rows,cols);
            Console.Write("\nEnter Values In Double Array:");
            double[,] doublearr = new double[rows, cols];
            Utility.ReadArray(doublearr, rows, cols);
            Console.Write("\nEnter Values In Boolean Array:");
            bool[,] booleanarr = new bool[rows, cols];
            Utility.ReadArray(booleanarr, rows, cols);
            Console.Write("\nPrint Integer Array: ");
            Utility.PrintArray(intarr,rows,cols);
            Console.Write("\nPrint Double Array: ");
            Utility.PrintArray(doublearr, rows, cols);
            Console.Write("\nPrint Boolean Array: ");
            Utility.PrintArray(booleanarr, rows, cols);
        }
    }
}
