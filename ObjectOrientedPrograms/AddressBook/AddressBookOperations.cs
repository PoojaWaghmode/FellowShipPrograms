// <copyright file=" AddressBookOperations.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ObjectOrientedProgramss.AddressBook
{
    /// <summary>
    /// Here AddressBookOperations class implements the AddressBookInterface
    /// </summary>
    /// <seealso cref="ObjectOrientedProgramss.AddressBook.AddressBookInterface" />
    public class AddressBookOperations : AddressBookInterface
    {
        /// <summary>
        /// Creates new entry for Addressbook.
        /// </summary>
        public void NewEntry()
        {
            ////It will reads values from user and validate it
            try
            {
            FullName:
                Console.Write("\nEnter Full name: ");
                string name = Console.ReadLine();
                if (Regex.IsMatch(name, @"[A-Za-z]")) { }
                else
                {
                    Console.WriteLine("Plz Enter Proper Name: ");
                    Console.Write("Re-Enter the Full Name: ");
                    goto FullName;
                }
            Address:
                Console.Write("\nEnter the Address: ");
                string address = Console.ReadLine();
                if (Regex.IsMatch(address, @"[A-Za-z\.@]")) { }
                else
                {
                    Console.WriteLine("Plz Enter Proper Address: ");
                    Console.Write("Re-Enter The Address: ");
                    goto Address;
                }
                Console.Write("\nEnter the state: ");
                string state = Console.ReadLine();
                Console.Write("\nEnter the city: ");
                string city = Console.ReadLine();
                Console.Write("Enter the pin code: ");

            Pincode:
                string pin = Console.ReadLine();
                if (Regex.IsMatch(pin, @"^[0-9]{6}$"))
                { }
                else
                {
                    Console.WriteLine("Plz Enter Valid PinCode ");
                    Console.Write("Re-Enter the 6 digit pin code: ");
                    goto Pincode;

                }
            PhoneNumber:
                Console.Write("\nEnter the phone number: ");
                string phoneNumber = Console.ReadLine();
                if (Regex.IsMatch(phoneNumber, @"^[0-9]{10}$"))
                { }
                else
                {
                    Console.WriteLine("Plz Enter Valid PhoneNumber ");
                    Console.Write("Re-Enter the 10 digit Phone Number: ");
                    goto PhoneNumber;
                }
                ////After Entered proper information needs to save that new entry.Here calls the SaveEntry() method
                SaveEntry(name, address, state, city, pin, phoneNumber);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
        /// <summary>
        /// Saves the entry.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="state">The state.</param>
        /// <param name="city">The city.</param>
        /// <param name="pin">The pin.</param>
        /// <param name="phoneNumber">The phone number.</param>
       public void SaveEntry(string name, string address, string state, string city, string pin, string phoneNumber)
        {
            try
            {
                ////here list of addressbook data is generated which contains all data of addressbook 
                List<AddressBookData> addressBook = new List<AddressBookData>();

                ////If here all validations true then it will assign the values
                if (Regex.IsMatch(phoneNumber, @"[0-9]{10}") && Regex.IsMatch(pin, @"[0-6]") && Regex.IsMatch(name, @"[a-zA-Z]") && Regex.IsMatch(city, @"[a-zA-Z]") && Regex.IsMatch(state, @"[a-zA-Z]"))
                {
                    AddressBookData addressBookModel = new AddressBookData()
                    {
                        FullName = name,
                        Address = address,
                        City = city,
                        State = state,
                        Pin = pin,
                        MobileNumber = phoneNumber
                    };

                    string path = @"C:\Users\User\source\repos\ObjectOrientedProgramss\AddressBook\AddressBook.json";

                    ////Here OpenText() method returns instance of streamreader which can be then used for read all text 
                    StreamReader reader = File.OpenText(path);

                    ////Here we will holds the all text into jsonsBook string
                    string jsonsBook = reader.ReadToEnd();

                    ////here the string is converts into object By using Deserialization and stores in addressData object i.e object of List of AddressBookDAta
                    addressBook = JsonConvert.DeserializeObject<List<AddressBookData>>(jsonsBook);

                    /////Then it will adds the data in addressbook
                    addressBook.Add(addressBookModel);

                    ////and then it will convert into object to string when we want to write
                    var convertedJson = JsonConvert.SerializeObject(addressBook);
                    reader.Close();
                    ////here writes all text to json file
                    File.WriteAllText(path, convertedJson);
                    Console.WriteLine("New Entry Added to the file");
                    DisplayAddressBook();
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Information");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        /// <summary>
        /// Deletes the entry from addressbook.
        /// </summary>
        public void DeleteEntry()
        {
            try
            {
                ////here i will give the path of json file from where i want to delete the entry 
                string path = @"C:\Users\User\source\repos\ObjectOrientedProgramss\AddressBook\AddressBook.json";

                ////here i will delete entry from json file if entered mobile number is matched with json file data 
                Console.Write("Enter PhoneNumber To Delete Your Entry:");
                string phoneNumber = Console.ReadLine();

                ////Makes the List of type AddressBookData 
                List<AddressBookData> addressData = new List<AddressBookData>();

                ////Here OpenText() method returns instance of streamreader which can be then used for read all text 
                StreamReader reader = File.OpenText(path);

                ////Here we will holds the all text into jsonsBook string
                string jsonsBook = reader.ReadToEnd();

                ////here the string is converts into object By using Deserialization and stores in addressData object i.e object of List of AddressBookDAta
                addressData = JsonConvert.DeserializeObject<List<AddressBookData>>(jsonsBook);
                bool ifNumber = false;

                //// Now after deserilization we have all data in addressData object so will traverse the list 
                foreach (var data in addressData)
                {
                   ////here number is exactly same then it will display all data of file 
                    if (data.MobileNumber == phoneNumber)
                    {
                        Console.Write("Full Name: " + data.FullName + "\n Address:  " + data.Address + "\n City:  " + data.City + "\n State:  " + data.State + "\n Pin Code: " + data.Pin + "\n Mobile Number:  " + data.MobileNumber+"\n");
                        ifNumber = true;
                    }
                }
                if (ifNumber == false)
                {
                    Console.WriteLine("No Entry with the above number found");
                }

                ////here used lamada expression and write function for find the mobilenumber if found then store in itemToRemove object
                var itemToRemove = addressData.Find(x => x.MobileNumber == phoneNumber);

                ////Here remove the entry of entered number by using Remove()
                addressData.Remove(itemToRemove);
                Console.WriteLine("your record deleted");

                ////addressData is json object and we have to write the changes in file so we have convert it into javaobject to json string
                var convertedJson = JsonConvert.SerializeObject(addressData);
                reader.Close();
                
                ////And writes to the file
                File.WriteAllText(path, convertedJson);
               
                ////It will display addressbook after deletion of entry
                DisplayAddressBook();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void DisplayAddressBook()
        {
            try
            {
                ////here i will give the path of json file 
                string path = @"C:\Users\User\source\repos\ObjectOrientedProgramss\AddressBook\AddressBook.json";

                ////it will creates the list of records in addressbook data
                List<AddressBookData> addressBook = new List<AddressBookData>();

                ////Here OpenText() method returns instance of streamreader which can be then used for read all text
                StreamReader reader = File.OpenText(path);
                string jsonsBook = reader.ReadToEnd();

                ////here the string is converts into object By using Deserialization and stores in addressData object i.e object of List of AddressBookDAta
                addressBook = JsonConvert.DeserializeObject<List<AddressBook.AddressBookData>>(jsonsBook);

                ////it will traverse the listdata
                foreach (var data in addressBook)
                {
                    Console.Write("Full Name: " + data.FullName + "\n Address: " + data.Address + "\n City:  " + data.City + "\n State:  " + data.State + "\n Pin Code:  " + data.Pin + "\n Mobile Number:  " + data.MobileNumber);
                    Console.WriteLine();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        /// <summary>
        /// Updates the entry of addressbook 
        /// </summary>
        public void UpdateEntry()
        {
            try
            {
                ////here we will updates the entries of addressbook as per the phonenumber
                Console.WriteLine("Enter your phone number to update");
                string phoneNumber = Console.ReadLine();

                ////path of json file
                string path = @"C:\Users\User\source\repos\ObjectOrientedProgramss\AddressBook\AddressBook.json";

                List<AddressBookData> addressData = new List<AddressBookData>();

                ////Here OpenText() method returns instance of streamreader which can be then used for read all text
                StreamReader reader = File.OpenText(path);
                string jsonsBook = reader.ReadToEnd();

                addressData = JsonConvert.DeserializeObject<List<AddressBookData>>(jsonsBook);
                bool number = false;

                foreach (var data in addressData)
                {
                    ////here number is exactly same then it will display all data of file 
                    if (data.MobileNumber == phoneNumber)
                    {
                        Console.WriteLine(data.FullName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Pin + " " + data.MobileNumber);
                        number = true;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Valid MobileNo.");

                    }
                    ////if number is found in Addressbook then we can update number,Address,State,City
                    string doCondition = null;
                    Console.WriteLine("Enter the field you want to update");
                    do
                    {
                        Console.WriteLine("1.Update Phone number");
                        Console.WriteLine("2.Update Address");
                        Console.WriteLine("3 Update State");
                        Console.WriteLine("4 Update City");
                        int update = Convert.ToInt32(Console.ReadLine());

                        switch (update)
                        {
                            case 1:
                                UpdateNumber(data);
                                break;
                            case 2:
                                UpdateAddress(data);
                                break;
                            case 3:
                                UpdateState(data);
                                break;
                            case 4:
                                UpdateState(data);
                                break;
                        }

                        Console.WriteLine("Enter y To continue or Enter any key to stop");
                        doCondition = Console.ReadLine();
                    }
                    while (doCondition.Equals("y"));

                    var convertedJson = JsonConvert.SerializeObject(addressData);
                    reader.Close();
                    
                    ////write updated data to json file
                    File.WriteAllText(path, convertedJson);
                    Console.WriteLine("Record updated");
                    DisplayAddressBook();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        /// <summary>
        /// Updates the Address.
        /// </summary>
        /// <param name="data">The data.</param>
        public void UpdateAddress(AddressBookData data)
        {
            try
            {
                Console.WriteLine("Enter new address");
                string newAddress = Console.ReadLine();
                data.Address = newAddress;

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
        /// <summary>
        /// Updates the city.
        /// </summary>
        /// <param name="data">The data.</param>
        public void UpdateCity(AddressBookData data)
        {
            try
            {
                Console.WriteLine("Enter new city");
                string newCity = Console.ReadLine();
                if (Regex.IsMatch(newCity, @"[a-zA-Z]"))
                {
                    data.City = newCity;
                }
                else
                {
                    Console.WriteLine("invalid data");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        /// <summary>
        /// Updates the number.
        /// </summary>
        /// <param name="data">The data.</param>
        public void UpdateNumber(AddressBookData data)
        {
            try
            {
                Console.WriteLine("Enter new number");
                string newPhoneNumber = Console.ReadLine();
                if (Regex.IsMatch(newPhoneNumber, @"[0-9]{10}"))
                {
                    data.MobileNumber = newPhoneNumber;
                }
                else
                {
                    Console.WriteLine("Enter a valid number");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
        /// <summary>
        /// Updates the state.
        /// </summary>
        /// <param name="data">The data.</param>
        public void UpdateState(AddressBookData data)
        {
            try
            {
                Console.WriteLine("enter new state");
                string newState = Console.ReadLine();
                if (Regex.IsMatch(newState, @"[a-zA-Z]"))
                {
                    data.State = newState;
                }
                else
                {
                    Console.WriteLine("invalid data");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }


    }
}