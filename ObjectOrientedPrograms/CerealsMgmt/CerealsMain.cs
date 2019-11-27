// <copyright file="CerealsMain.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramss.CerealsMgmt
{
    public class CerealsMain
    {
        public static void GetCerealsInfo()
        {
            bool flag = true;
            while(flag)
            {
                try 
                {
                    CerealsOperations cereals = new CerealsOperations();
                    Console.WriteLine("..........Cereals Management......");
                    Console.WriteLine("\n\t1.Add New Cereals\n\t2.Display Cereals\n\t3.Exit");
                    Console.WriteLine("Enter Choice:");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            cereals.Add();
                            break;
                        case 2:
                            cereals.Display();
                            break;
                        case 3:
                            flag = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice Plz Enter Choice 1 to 3");
                            break;
                    }

                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }


            }
        }
    }
}
