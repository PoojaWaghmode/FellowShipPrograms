using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BubbleSort
    {
        public void Sort()
        {
            Console.Write("Enter How Many Elements Insert In Array ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intarray = new int[size];
            Console.Write("Enter Elements In Array:");
            Utility.ReadIntArray(intarray);
            Console.Write("Elements Before Sorting:");
            Utility.PrintIntarray(intarray);
            Utility.BubbleSortOfArray(intarray,size);
            Console.Write("\nElements After Sorting:");
            Utility.PrintIntarray(intarray);

        }
    }
}
