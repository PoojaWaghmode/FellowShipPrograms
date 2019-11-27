// <copyright file="AddressBookData.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedProgramss.AddressBook
{ 
    /// <summary>
    /// This class Contains All Fields Of Addressbook
    /// </summary>
    public class AddressBookData
    {
        ////private data members i.e here encapsulation is used
        
        private string fullName;
        private string address;
        private string mobileNumber;
        private string state;
        private string pin;
        private string city;
        ////private data members  are accessed using getter setters i.e here encapsulation is used for accessing private members through public methods
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public string State { get => state; set => state = value; }
        public string Pin { get => pin; set => pin = value; }
        public string City { get => city; set => city = value; }
    }
}
