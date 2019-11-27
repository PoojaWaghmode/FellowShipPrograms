// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using ObjectOrientedProgramss.AddressBook;
using ObjectOrientedProgramss.CerealsMgmt;
using ObjectOrientedProgramss.CommercialDataManagement;
using ObjectOrientedProgramss.InventoryDataManagementOfCereals;
using ObjectOrientedProgramss.StockPortfollio;
using System;

namespace ObjectOrientedProgramss
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
           
            while (flag)
            {
                try
                {
                    Console.WriteLine("..........Object Oriented Programs......");
                    Console.WriteLine("\n\t1. Implementations Of AddressBook\n\t2. Inventory Management Of Cereals\n\t3.Stock portFollio\n\t4.Commercial Data Management\n\t5.Cereals Management\n\t6.Exit\n");
                    Console.WriteLine("Enter Choice:");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            AddressBookMain addressBook = new AddressBookMain();
                            addressBook.ImplementationOfAddressBook();
                            break;
                        case 2:
                            InventoryDataManagementOfCerealsMain.InventoryDataManagementReport();
                            break;
                        case 3:
                            StockPortfolio.StockReport();
                            break;
                        case 4:
                            UserStockAccountData userdata = new UserStockAccountData();
                            userdata.UserGetInput();
                            break;
                       
                        case 5:
                            CerealsMain.GetCerealsInfo();
                            break;
                           
                        case 6:
                            flag= false;
                            break;

                        default:
                            break;


                    }
                }catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

            }
        }
    }
}
