// <copyright file="CerealsInterface.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedProgramss.CerealsMgmt
{
    /// <summary>
    /// Interface it only displays methods declaration which ara used in throughout application
    /// </summary>
    interface CerealsInterface
    {
        void Add();
        void Display();
        void saveData(string cname,double cprice,double cweight);
    }
}
