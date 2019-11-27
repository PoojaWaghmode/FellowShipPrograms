// <copyright file=" InventoryManagementUtility.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
namespace ObjectOrientedProgramss.InventoryDataManagementOfCereals
{
    /// <summary>
    /// Here implemented the all operations of interface
    /// </summary>
    /// <seealso cref="ObjectOrientedProgramss.InventoryDataManagementOfCereals.InventoryDataManagementInterface" />
    class InventoryManagementUtility : InventoryDataManagementInterface
    {
        public string jsonFile = @"C:\Users\User\source\repos\ObjectOrientedProgramss\InventoryDataManagementOfCereals\Cereals.json";

        /// <summary>
        /// Displays the rice details.
        /// </summary>
        public void DisplayRiceDetails()
        {
            ////it will reads the jsonfile and holds in json object
            var json = File.ReadAllText(jsonFile);
            try
            { 
                ////here we parses the data and stores in jobject
                var jObject = JObject.Parse(json);

                ////fetch data upto jobject not becomes null
                if (jObject != null)
                {
                    ////it creates the jarray of object 
                    JArray riceArrary = (JArray)jObject["Rice"];
                    if (riceArrary != null)
                    {
                        foreach (var item in riceArrary)
                        {
                            Console.WriteLine("Rice Name :" + item["riceName"]);
                            Console.WriteLine("Rice Price :" + item["ricePrice"]);
                            Console.WriteLine("Rice Weight:" + item["riceWeight"]);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Adds the pulse details.
        /// </summary>
        public void AddPulseDetails()
        {
            Console.WriteLine("Enter Pulse Name:");
            string pulseName = Console.ReadLine();
            Console.WriteLine("Enter Pulse Price:");
            double pulsePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Pulse Weight:");
            double pulseWeight = Convert.ToDouble(Console.ReadLine());
            var newPulseMember = "{'pulsename'" + pulseName + ",'pulseprice'" + pulsePrice + ",'pulseweight'" + pulseWeight + " }";
            try
            {
                var json = File.ReadAllText(jsonFile);
                var jsonObj = JObject.Parse(json);
                var pulseArrary = jsonObj.GetValue("Pulse") as JArray;
                var newPulse = JObject.Parse(newPulseMember);
                pulseArrary.Add(newPulse);

                jsonObj["Pulse"] = pulseArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonFile, newJsonResult);


            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Adds the rice details.
        /// </summary>
        public void AddRiceDetails()
        {
            Console.WriteLine("Enter Rice Name:");
            string riceName = Console.ReadLine();
            Console.WriteLine("Enter Rice Price:");
            double ricePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rice Weight:");
            double riceWeight = Convert.ToDouble(Console.ReadLine());
            var newRiceMember = "{'ricename':" + riceName + ",'riceprice':" + ricePrice + ",'riceweight':" + riceWeight + "'}";
            try
            {
                var json = File.ReadAllText(jsonFile);
                var jsonObj = JObject.Parse(json);
                var riceArrary = jsonObj.GetValue("Rice") as JArray;
                var newRice = JObject.Parse(newRiceMember);
                Console.WriteLine(newRice);
                riceArrary.Add(newRice);

                jsonObj["Rice"] = riceArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonFile, newJsonResult);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Adds the wheat details.
        /// </summary>
        public void AddWheatDetails()
        {
            Console.WriteLine("Enter Wheat Name:");
            string wheatName = Console.ReadLine();
            Console.WriteLine("Enter Wheat Price:");
            double wheatPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Wheat Weight:");
            double wheatWeight = Convert.ToDouble(Console.ReadLine());
            var newRiceMember = "{'wheatname': " + wheatName + ",'wheatprice': " + wheatPrice + ",'wheatweight': " + wheatWeight + " }";
            try
            {
                var json = File.ReadAllText(jsonFile);
                var jsonObj = JObject.Parse(json);
                var wheatArrary = jsonObj.GetValue("Wheat") as JArray;
                var newRice = JObject.Parse(newRiceMember);
                wheatArrary.Add(newRice);

                jsonObj["Wheat"] = wheatArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonFile, newJsonResult);


            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Deletes the pulse details.
        /// </summary>
        public void DeletePulseDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray cerealsArrary = (JArray)jObject["cereals"];
                Console.Write("Enter Pulse Name to Delete : ");
                var pulseName = Console.ReadLine();
                if (pulseName.Length > 0)
                {
                    var updatedpulseName = string.Empty;
                    var pulseToDeleted = cerealsArrary.FirstOrDefault(obj => obj["pulsename"].Value<string>() == pulseName);
                    cerealsArrary.Remove(pulseToDeleted);
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);

                }
                else
                {
                    Console.Write("Invalid Pulse Name, Try Again!");
                    UpdatePulseDetails();

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Deletes the rice details.
        /// </summary>
        public void DeleteRiceDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray cerealsArrary = (JArray)jObject["cereals"];
                Console.Write("Enter Rice Name to Delete : ");
                var riceName = Console.ReadLine();
                if(riceName.Length>0)
                {
                    var riceName1 = string.Empty;
                    var riceToDeleted = cerealsArrary.FirstOrDefault(obj => obj["ricename"].Value<string>() == riceName);
                    cerealsArrary.Remove(riceToDeleted);
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
                else
                {
                    Console.Write("Invalid Rice Name, Try Again!");
                    UpdateRiceDetails();
                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Deletes the wheat details.
        /// </summary>
        public void DeleteWheatDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray cerealsArrary = (JArray)jObject["cereals"];
                Console.Write("Enter Wheat Name to Delete : ");
                var wheatName = Console.ReadLine();
                if (wheatName.Length > 0)
                {
                    var updatedwheatname = string.Empty;
                    var wheatToDeleted = cerealsArrary.FirstOrDefault(obj => obj["wheatname"].Value<string>() == wheatName);
                    cerealsArrary.Remove(wheatToDeleted);
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
                else
                {
                    Console.Write("Invalid Wheat Name, Try Again!");
                    UpdateWheatDetails();

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Displays the pulse details.
        /// </summary>
        public void DisplayPulseDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                if (jObject != null)
                {

                    JArray pulseArrary = (JArray)jObject["Pulse"];
                    if (pulseArrary != null)
                    {
                        foreach (var item in pulseArrary)
                        {
                            Console.WriteLine("Pulse Name :" + item["pulseName"]);
                            Console.WriteLine("Pulse Price :" + item["pulsePrice"]);
                            Console.WriteLine("Pulse Weight:" + item["pulseWeight"]);
                        }

                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }


        /// <summary>
        /// Displays the wheat details.
        /// </summary>
        public void DisplayWheatDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {

                var jObject = JObject.Parse(json);
                if (jObject != null)
                {

                    JArray wheatArray = (JArray)jObject["Wheat"];
                    if (wheatArray != null)
                    {
                        foreach (var item in wheatArray)
                        {
                            Console.WriteLine("Wheat Name :" + item["wheatName"]);
                            Console.WriteLine("Wheat Price :" + item["wheatPrice"]);
                            Console.WriteLine("Wheat Weight:" + item["wheatWeight"]);
                        }

                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Updates the pulse details.
        /// </summary>
        public void UpdatePulseDetails()
        {
            try
            {

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Updates the rice details.
        /// </summary>
        public void UpdateRiceDetails()
        {
            string json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray riceArray = (JArray)jObject["Rice"];
               
                Console.Write("Enter Rice Name To Update  : ");
                var riceName =Console.ReadLine();

                if (riceName.Length> 0)
                {
                    Console.Write("Enter new Rice name : ");
                    var updatedriceName = Console.ReadLine();

                    foreach (var rice in riceArray.Where(obj => obj["riceName"].Value<string>() == updatedriceName))
                    {
                        rice["ricename"] = !string.IsNullOrEmpty(riceName) ? riceName : "";
                    }
                

                    jObject["Rice"] = riceArray;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
                else
                {
                    Console.Write("Invalid Rice Name, Try Again!");
                    UpdateRiceDetails();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Updates the wheat details.
        /// </summary>
        public void UpdateWheatDetails()
        {
            string json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray wheatArray = (JArray)jObject["Wheat"];

                Console.Write("Enter Wheat Name To Update  : ");
                var wheatName = Console.ReadLine();

                if (wheatName.Length > 0)
                {
                    Console.Write("Enter new Wheat name : ");
                    var updatedwheatName = Console.ReadLine();

                    foreach (var wheat in wheatArray.Where(obj => obj["wheatName"].Value<string>() == updatedwheatName))
                    {
                        wheat["wheatname"] = !string.IsNullOrEmpty(wheatName) ? wheatName : "";
                    }
                    jObject["Wheat"] = wheatArray;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
                else
                {
                    Console.Write("Invalid Wheat Name, Try Again!");
                    UpdateWheatDetails();

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
