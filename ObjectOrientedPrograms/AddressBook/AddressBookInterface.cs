// <copyright file="AddressBookInterface.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedProgramss.AddressBook
{
    /// <summary>
    /// This is interface for AddressBook here all methods are declared which will useful throughout the application 
    /// </summary>
    public interface AddressBookInterface
    {
         void DisplayAddressBook();
         void NewEntry();
         void SaveEntry(string name, string address, string state, string city, string pin, string phoneNumber);
         void DeleteEntry();
         void UpdateEntry();
         void UpdateNumber(AddressBookData data);
         void UpdateAddress(AddressBookData data);
         void UpdateState(AddressBookData data);
         void UpdateCity(AddressBookData data);
        
    }
}
