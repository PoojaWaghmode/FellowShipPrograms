// <copyright file=" StockPortfolio.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramss.StockPortfollio
{
    /// <summary>
    /// This class for implementation of stock/shares portfollio
    /// </summary>
    class StockPortfolio
    {
        /// <summary>
        /// Stocks the report.
        /// </summary>
        public static void StockReport()
        {

            ////Reads the number of companies want to to invest in shares
            Console.Write("\nEnter How Many Companies Want To Invest stocks/Shares : ");
            int numberOfStock = Convert.ToInt32(Console.ReadLine());

            ////it will create the array of size entered by user
            StockData[] stock = new StockData[numberOfStock];

            ////it will iterate loop upto number of stocks
            for (int i = 0; i < numberOfStock; i++)
            {
                stock[i] = new StockData();

                stock[i].StockGetInput();
            }

            ////it will create the list of type StockData
            List<StockData> writeStock = new List<StockData>();
 
            ////it will add data upto number of stock
            for (int i = 0; i < numberOfStock; i++)
            {
                writeStock.Add(stock[i]);
            }

            ////it converts object into string
            string jsonStock = JsonConvert.SerializeObject(stock, Formatting.Indented);
            
            ////set the path
            string path = @"C:\Users\User\source\repos\ObjectOrientedProgramss\StockPortfollio\Stockportfollio.json";

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStock);

            streamWriter.Close();
 
            StreamReader streamReader = new StreamReader(path);

            string readString = streamReader.ReadToEnd();

            ////it will converts string into object
            List<StockData> stockList = JsonConvert.DeserializeObject<List<StockData>>(readString);
            double totalSharePrice = 0;

            ////iterate the list StockData
            foreach (StockData objStock in stockList)
            {
                totalSharePrice = objStock.SharePrice * objStock.NumberOfShare;
                Console.WriteLine("Name Of Stock : " + objStock.NameOfShare);
                Console.WriteLine("Total Share : " + objStock.NumberOfShare);
                Console.WriteLine("Each Share Price " + objStock.SharePrice);
                Console.WriteLine("Total Share Price of Stock " + totalSharePrice);
            }
            Console.WriteLine("Where You Want to Invest Your Share");
            string userStockName = Console.ReadLine();

            foreach (StockData objStock in stockList)
            {
                try
                {
                    ////it will checks the companies data in list stockdata and if it found then it will perform the below operations
                    if (userStockName.Equals(objStock.NameOfShare))
                    {
                        Console.Write("\nHow Many Share You Want To Buy:");
                        int userNumberOfShare = Convert.ToInt32(Console.ReadLine());
                        double totalUserSharePrice = userNumberOfShare * objStock.SharePrice;
                        int availableShare = objStock.NumberOfShare - userNumberOfShare;
                        Console.WriteLine("Your Total Share Price : " + totalUserSharePrice);
                        Console.WriteLine("Available Share Of {0} is {1}", objStock.NameOfShare, availableShare);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}

