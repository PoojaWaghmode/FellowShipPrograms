// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Basic_Programs
{
    using System;
    /// <summary>
    /// This Class for Flip Coin and print percentage of Heads and Tails 
    /// </summary>
    class FlipCoin
    {
        /// <summary>
        /// CoinFlip Method Reads the no. of Flips and checks the validations and calls the FlipCoin() Method
        /// </summary>
        public void CoinFlip()
        {
            Utility u = new Utility();
            ///Read No. Of Flip
            Console.Write("Enter How Many Times You Want To Flip: ");
            int num = Convert.ToInt32(Console.ReadLine());
            ///Ensure No. Of Flips Must Be Positive
            if (num > 0)
            {
                u.FlipCoin(num);
            }
            else
            {
                Console.WriteLine("Number Must Be Positive");
            }

        }
    }
}
