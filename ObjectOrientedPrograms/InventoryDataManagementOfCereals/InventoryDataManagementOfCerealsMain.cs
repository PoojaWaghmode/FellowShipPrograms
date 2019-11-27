// <copyright file=" InventoryDataManagementOfCerealsMain.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace ObjectOrientedProgramss.InventoryDataManagementOfCereals
{
    class InventoryDataManagementOfCerealsMain
    {
        public static void InventoryDataManagementReport()
        {
            bool flag = true;
            while(flag)
            {
                try
                {
                    Console.WriteLine(".....Inventory Data Management Of Cereals......");
                    Console.WriteLine("\n\t1.Display All Rice Details\n\t2.Add Rice Details\n\t3.Update Rice Details\n\t4.Delete Rice Details\n\t5.Display Wheat Details\n\t6.Add Wheat Details\n\t7.Update Wheat Details\n\t8.Delete Wheat Details\n\t9.Display Pulse Details\n\t10.Add Pulse Details\n\t11.Update Pulse Details\n\t12.Delete Pulse Details\n\t13.Exit");
                    try
                    {
                        Console.WriteLine("Choose Option To Perform Operation");
                        int option = Convert.ToInt32(Console.ReadLine());
                        InventoryManagementUtility inventoryManagement = new InventoryManagementUtility();

                    switch (option)
                    {
                        case 1:
                            inventoryManagement.DisplayRiceDetails();
                            break;

                        case 2:
                            inventoryManagement.AddRiceDetails();
                            break;
                        case 3:
                            inventoryManagement.UpdateRiceDetails();
                            break;
                        case 4:
                            inventoryManagement.DeleteRiceDetails();
                            break;
                        case 5:
                            inventoryManagement.DisplayWheatDetails();
                            break;
                        case 6:
                            inventoryManagement.AddWheatDetails();
                            break;
                        case 7:
                            inventoryManagement.UpdateRiceDetails();
                            break;
                        case 8:
                            inventoryManagement.DeleteWheatDetails();
                            break;
                        case 9:
                            inventoryManagement.DisplayPulseDetails();
                            break;
                        case 10:
                            inventoryManagement.AddPulseDetails();
                            break;
                        case 11:
                            inventoryManagement.UpdatePulseDetails();
                            break;
                        case 12:
                            inventoryManagement.DeletePulseDetails();
                            break;
                        case 13:
                            flag = false;
                            break;
                        default:
                                Console.WriteLine("Enter Choice Between 1 to 12");
                                break;
                    }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
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
