// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    class Utility
    {
        /// <summary>
        /// Reads the array.
        /// </summary>
        /// <param name="intarr">The intarr.</param>
        /// <param name="rows">The rows.</param>
        /// <param name="cols">The cols.</param>
        public static void ReadArray(int[,] intarr,int rows,int cols)
        {   IntegerArray:
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("Element: [{0},{1}] : ", i, j);
                        intarr[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Input Please Enter Integer Value");
                goto IntegerArray;
            }

        }
        /// <summary>
        /// Reads the array.
        /// </summary>
        /// <param name="doublearr">The doublearr.</param>
        /// <param name="rows">The rows.</param>
        /// <param name="cols">The cols.</param>
        public static void ReadArray(double[,] doublearr, int rows, int cols)
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Element: [{0},{1}] : ", i, j);
                    doublearr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        /// <summary>
        /// Reads the array.
        /// </summary>
        /// <param name="booleanarr">The booleanarr.</param>
        /// <param name="rows">The rows.</param>
        /// <param name="cols">The cols.</param>
        public static void ReadArray(bool[,] booleanarr,int rows, int cols)
        {
            BooleanArray:
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("Element: [{0},{1}] : ", i, j);
                        booleanarr[i, j] = Convert.ToBoolean(Console.ReadLine());
                    }
                }
            }
            catch
            {
                Console.WriteLine("Wrong Input Please Enter Boolean Values");
                goto BooleanArray;
            }
           
        }
        /// <summary>
        /// Prints the array.
        /// </summary>
        /// <param name="intarr">The intarr.</param>
        /// <param name="rows">The rows.</param>
        /// <param name="cols">The cols.</param>
        public static void PrintArray(int[,] intarr,int rows,int cols)
        {
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.Write("\t\n{0}",intarr[i,j]);
                }
            }
        }
        /// <summary>
        /// Prints the array.
        /// </summary>
        /// <param name="doublearr">The doublearr.</param>
        /// <param name="rows">The rows.</param>
        /// <param name="cols">The cols.</param>
        public static void PrintArray(double[,] doublearr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("\t\n{0}", doublearr[i,j]);
                }
            }
        }
        /// <summary>
        /// Prints the array.
        /// </summary>
        /// <param name="boolarr">The boolarr.</param>
        /// <param name="rows">The rows.</param>
        /// <param name="cols">The cols.</param>
        public static void PrintArray(bool[,] boolarr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("\t\n{0}", boolarr[i,j]);
                }
            }
        }
        /// <summary>
        /// Finds the sum zero triplet.
        /// </summary>
        /// <param name="a">a.</param>
        public static void FindSumZeroTriplet(int[] a)
        {
            int countforsumzero = 0,countfornotzero=0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    for (int k = j + 1; k < a.Length; k++)
                    {
                       
                        if (a[i] + a[j] + a[k] == 0)
                        {
                            Console.WriteLine("Distinct Triplets are:  " + a[i] + "  " + a[j] + " " + a[k]);
                            countforsumzero++;
                        }
                        else
                        {
                            Console.WriteLine("Distinct triplets are not found :" + a[i] + "  " + a[j] + " " + a[k]);
                            countfornotzero++;
                        }
                       
                    }
                }
            }
            Console.WriteLine("No.Of Distinct Triplets Are :" + countforsumzero);
            Console.WriteLine("No.Of Distinct Triplets Not Found :" + countfornotzero);
            
        }
        /// <summary>
        /// Calculates the distance.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public double calculateDistance(int x,int y)
        {
            double distance =Math.Sqrt( x * x + y * y);
            return distance;
        }
        /// <summary>
        /// Calculates the roots.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public static void CalculateRoots(int a,int b,int c)
        {
            try { 
            double delta = b * b - 4 * a * c;
            Console.WriteLine("Delta: "+delta);
                if (delta > 0)
                {

                    double squarerrootdelta = (Math.Sqrt(delta));
                    Console.WriteLine("SquareRoot Of Delta: " + squarerrootdelta);
                    double Root_1_of_x = (-b + (squarerrootdelta)) / (2 * a);
                    double Root_2_of_x = (-b - squarerrootdelta) / (2 * a);
                    Console.WriteLine("Root 1 Of X: " + Root_1_of_x);
                    Console.WriteLine("Root 2 Of X :  " + Root_2_of_x);
                }
                else
                {
                    Console.WriteLine("Sorry Delta Value Is Negative..Negative Numbers Can't Have Squareroot   ");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Null Exception");
            }

        }
        /// <summary>
        /// Calculates the wind chill.
        /// </summary>
        /// <param name="temp">The temporary.</param>
        /// <param name="velocity">The velocity.</param>
        /// <returns></returns>
        public double CalculateWindChill(double temp,double velocity)
        {
            double windchill=(35.74 + (0.6215 * temp) + (0.4275 * temp) - 35.75) * Math.Pow(velocity, 0.16); 
            return windchill ;
        }
    }
}
