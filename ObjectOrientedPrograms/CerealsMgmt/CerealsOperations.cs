// <copyright file=" CerealsOperations.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramss.CerealsMgmt
{
    /// <summary>
    /// Implements the methods 
    /// </summary>
    /// <seealso cref="ObjectOrientedProgramss.CerealsMgmt.CerealsInterface" />
    public class CerealsOperations : CerealsInterface
    {
        /// <summary>
        /// Adds this instance.
        /// </summary>
        public void Add()
        {
            try
            {
                string path = @"C:\Users\User\source\repos\ObjectOrientedProgramss\CerealsMgmt\Cereals.json";
                Console.WriteLine("Enter Cereal Name:");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter Cereal Price");
                double cprice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Cereal Weight:");
                double cweight = Convert.ToDouble(Console.ReadLine());
                saveData(cname,cprice,cweight);

            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            try
            {
                string path = @"C:\Users\User\source\repos\ObjectOrientedProgramss\CerealsMgmt\Cereals.json";
                IList<CerealsData> cereals = new List<CerealsData>();
                StreamReader reader = File.OpenText(path);
                string jsonsBook = reader.ReadToEnd();
                cereals = JsonConvert.DeserializeObject<List<CerealsData>>(jsonsBook);
                foreach (var data in cereals)
                {
                    Console.Write("CerealsName: " + data.Name + "\n CerealsPrice: " + data.Price + "\n CerealsWeight:  " + data.Weight);
                    Console.WriteLine();
                }

            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }
        /// <summary>
        /// Saves the data.
        /// </summary>
        /// <param name="cname">The cname.</param>
        /// <param name="cprice">The cprice.</param>
        /// <param name="cweight">The cweight.</param>
        public void saveData(string cname, double cprice, double cweight)
        {
            IList<CerealsData> cereals = new List<CerealsData>();
            CerealsData cerealsdataobj = new CerealsData()
            {
                Name = cname,
                Price = cprice,
                Weight = cweight

            };
            string path = @"C:\Users\User\source\repos\ObjectOrientedProgramss\CerealsMgmt\Cereals.json";
            StreamReader reader = File.OpenText(path);

            string jsonsBook = reader.ReadToEnd();
            cereals = JsonConvert.DeserializeObject<List<CerealsData>>(jsonsBook);
            cereals.Add(cerealsdataobj);
            var convertedJson = JsonConvert.SerializeObject(cereals);
            reader.Close();
            File.WriteAllText(path, convertedJson);
            Console.WriteLine("New Entry Added to the file");
            Display();


        }
    }
}
