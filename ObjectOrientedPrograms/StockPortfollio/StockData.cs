// <copyright file=" StockData.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramss.StockPortfollio
{
    class StockData
    {
        private string nameOfShare;
        private int numberOfShare;
        private double sharePrice;

        public string NameOfShare { get => nameOfShare; set => nameOfShare = value; }
        public int NumberOfShare { get => numberOfShare; set => numberOfShare = value; }
        public double SharePrice { get => sharePrice; set => sharePrice = value; }

        /// <summary>
        /// it will take input of Stocks 
        /// </summary>
        public void StockGetInput()
        {
            try
            {
                ////reads the company name
                Console.Write("\nEnter Company Name of Share:");
                this.NameOfShare = Console.ReadLine();

                ////reads the number of shares
                Console.Write("\nEnter How Many Shares ??:");
                this.NumberOfShare = Convert.ToInt32(Console.ReadLine());

                ////reads the price of every shares
                Console.Write("\nEnter Price of Per Share: ");
                this.SharePrice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exception)
            {
                Console.WriteLine("Please Enter Valide Input" + exception.Message);
            }

        }
    }
}
