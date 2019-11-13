using System;
namespace JUnitTesting_Programs
{
    class VendingMachine
    {
        public void FindNoOfNotesForChange()
        {
            int[] Notes =new int[]{2000,1000,500,100,50,20,10,5,2,1};
            int size = Notes.Length;
            Console.WriteLine("  " + size + " Different Notes Are Available In Vending Machine");
            Console.Write("Enter Amount In Rs:");
            int amount = Convert.ToInt32(Console.ReadLine());
            Utility.CalculateNotes(Notes,amount,size);


        }
    }
}
