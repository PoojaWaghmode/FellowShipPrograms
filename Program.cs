// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {

                    Console.WriteLine("\n Functional Programs:\n\t1.TwoDimensionalArray \n\t2.Triplets\n\t3.Calculate Distance\n\t4.Quadratic Equation\n\t5.WindChill\n\t6.Exit\n\n");
                    Console.Write("Enter Your Choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            TwoDimensionalArray twodimarr = new TwoDimensionalArray();
                            twodimarr.ReadWriteTwoDimensionalArray();
                            break;
                        case 2:
                            Triplet triplet = new Triplet();
                            triplet.SearchTriplet();
                            break;
                        case 3:
                            Distance distance = new Distance();
                            distance.FindDistance();
                            break;
                        case 4:
                            QuadraticEquation equation = new QuadraticEquation();
                            equation.FindRoots();
                            break;
                        case 5:
                            WindChill w = new WindChill();
                            w.FindWindChill();
                            break;
                        case 6:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid Input Enter Choice Between 1 To 7");
                }
            }
        }
    }
}
