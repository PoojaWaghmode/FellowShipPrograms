// <copyright file="AddressBookMain.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using System;
namespace ObjectOrientedProgramss.AddressBook
{
    /// <summary>
    /// This Class calls the methods of addressbook operations
    /// </summary>
    class AddressBookMain
    {
        /// <summary>
        /// Implementations the of address book.
        /// </summary>
        public void ImplementationOfAddressBook()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    AddressBookOperations addressBook = new AddressBookOperations();
                    Console.WriteLine("AddressBook Operations:\n\t1. Add New Entry In AddressBook\n\t2. Delete An Entry From AddressBook\n\t3. Update An Entry From AddressBook\n\t4. Display Address Book\n\t5. Exit\n");
                    Console.Write("Enter Your Choice: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            addressBook.NewEntry();
                            break;
                        case 2:
                            addressBook.DeleteEntry();
                            break;
                        case 3:
                            addressBook.UpdateEntry();
                            break;
                        case 4:
                            addressBook.DisplayAddressBook();
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Enter Valid Choice");
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
